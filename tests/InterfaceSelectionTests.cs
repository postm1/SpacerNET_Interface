using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SpacerUnion;
using SpacerUnion.Common;
class InterfaceSelectionTests {
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern float Test_GetOffset(int axis);
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern float Test_GetAngle(int axis);
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern int Test_GetFilter();
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern int Test_GetThrough();
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern int Test_GetUndo();
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern int Test_GetMode();
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern int Test_GetWorkMode();
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern int Test_GetLastAction();
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern void Test_SetPlaying(int value);
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern int Test_GetSingleSelectCalls();
    [DllImport("SpacerUnionNet.dll",CallingConvention=CallingConvention.Cdecl)]static extern int Test_GetSelectionCalls();
    [DllImport("user32.dll")]static extern IntPtr SendMessage(IntPtr window,int message,IntPtr wParam,IntPtr lParam);
    [DllImport("user32.dll")]static extern bool PostMessage(IntPtr window,int message,IntPtr wParam,IntPtr lParam);
    static int checks;
    static void Click(Button button){typeof(Button).GetMethod("OnClick",BindingFlags.NonPublic|BindingFlags.Instance).Invoke(button,new object[]{EventArgs.Empty});}
    static T Field<T>(object owner,string name){return (T)owner.GetType().GetField(name,BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance).GetValue(owner);}
    static void Call(object owner,string name){owner.GetType().GetMethod(name,BindingFlags.NonPublic|BindingFlags.Instance).Invoke(owner,null);}
    static void Check(bool result,string text){if(!result)throw new Exception(text);++checks;}
    static void TreeClick(TreeView tree,TreeNode node,int modifiers){
        node.EnsureVisible();
        Rectangle row=node.Bounds;
        var position=new IntPtr(((row.Top+row.Height/2)<<16)|(row.Left+3));
        // Queue both messages before dispatch: the native tree may wait for mouse-up
        // while detecting a drag on ordinary (unintercepted) clicks.
        PostMessage(tree.Handle,0x0201,new IntPtr(1|modifiers),position);
        PostMessage(tree.Handle,0x0202,new IntPtr(modifiers),position);
        Application.DoEvents();
    }
    static bool GroupSelected(TreeView tree,TreeNode node){return (bool)tree.GetType().GetMethod("IsGroupSelected",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(tree,new object[]{node});}
    [STAThread]static int Main(){
        try {
            Application.EnableVisualStyles();
            System.Threading.Thread.CurrentThread.CurrentCulture=CultureInfo.GetCultureInfo("pl-PL");
            Localizator.Init();
            typeof(Localizator).GetField("curLang",BindingFlags.Static|BindingFlags.NonPublic).SetValue(null,LangEnum.PL);
            Check(MainForm.IsMultiSelectionInputBlocked()==1,"Input blocked before interface initialization");
            using(var form=new MainForm()){
                var dialog=Field<GroupSelectionForm>(form,"multiSelectionWindow");
                try {
                    Check(dialog.TopLevel&&dialog.Owner==form&&!form.Controls.Contains(dialog),"Separate owned top-level window");
                    Check(form.Controls.Find("multiSelectionBar",true).Length==0,"No status-bar panel remains");
                    form.currentWorldName="test.zen";
                    var multiButton=Field<ToolStripButton>(form,"toolStripButtonMulti");
                    Size viewport=Field<Panel>(form,"panelMain").Size;
                    multiButton.Checked=true;Call(form,"RefreshMultiSelectionWindow");
                    Check(Field<Panel>(form,"panelMain").Size==viewport,"Viewport size preserved");
                    Check(Field<GroupBox>(dialog,"controlsGroup").Text=="Sterowanie","Controls section is visible in the group window");
                    Check(Field<Label>(dialog,"mouseHelp").Text.Contains("LPM")
                        &&Field<Label>(dialog,"mouseHelp").Text.Contains("Ctrl/Shift")
                        &&Field<Label>(dialog,"mouseHelp").Text.Contains("Alt"),"Controls describe viewport rectangles and Objects tree selection");
                    Check(Field<Label>(dialog,"cameraHelp").Text.Contains("PPM")
                        &&Field<Label>(dialog,"cameraHelp").Text.Contains("zachowuje"),"Controls describe camera and safe viewport activation");
                    var filter=Field<ComboBox>(dialog,"filter");
                    Check(filter.Items.Count==22,"Complete filter list");
                    Check(filter.Items[4].ToString()=="Tylko VOB (bez item i mover)","VOB semantics preserved");
                    Check(filter.Items[10].ToString()=="oCMobInter"&&filter.Items[19].ToString()=="zCTrigger","Distinct interactive and trigger filters");
                    Check(filter.Items[21].ToString()=="oCZoneMusic","Music zones included");
                    for(int i=0;i<filter.Items.Count;++i){
                        filter.SelectedIndex=i;Check(Test_GetFilter()==i,"Filter index reaches native code");
                    }
                    var through=Field<CheckBox>(dialog,"through");through.Checked=true;
                    Check(Test_GetThrough()==1,"Through-obstacles setting");
                    Check(Field<Label>(dialog,"selectedCount").Text=="Zaznaczono: 5","Live count");
                    var delta=Field<NumericUpDown[]>(dialog,"deltas");
                    delta[0].Value=100.125m;delta[1].Value=-25.5m;delta[2].Value=3m;
                    Click(Field<Button>(dialog,"apply"));
                    Check(Math.Abs(Test_GetOffset(0)-100.125f)<0.0001&&Math.Abs(Test_GetOffset(1)+25.5f)<0.0001
                        &&Test_GetOffset(2)==3&&Test_GetLastAction()==0,"Decimal translation reaches native code");
                    Check(Test_GetUndo()==1&&Field<Button>(dialog,"undo").Enabled,"Undo enabled");
                    Click(Field<Button>(dialog,"undo"));Check(Test_GetUndo()==0,"Translation undo");
                    var mode=Field<ComboBox>(dialog,"mode");mode.SelectedIndex=1;
                    Check(Test_GetMode()==1&&delta[0].Value==0&&delta[0].Maximum==3600,"Mode resets fields to angle limits");
                    Check(Field<Button>(dialog,"apply").Text=="Obróć zaznaczone","Rotation label");
                    Check(Field<Label>(dialog,"keyboardHelp").Text.Contains("Q/E")
                        &&Field<Label>(dialog,"keyboardHelp").Text.Contains("Shift"),"Rotation help includes axes and speed modifiers");
                    delta[1].Value=90;Click(Field<Button>(dialog,"apply"));
                    Check(Test_GetLastAction()==1&&Test_GetAngle(1)==90,"Native rotation entry point");
                    typeof(Localizator).GetField("curLang",BindingFlags.Static|BindingFlags.NonPublic).SetValue(null,LangEnum.EN);
                    dialog.UpdateLanguage();
                    Check(Field<GroupBox>(dialog,"controlsGroup").Text=="Controls"
                        &&Field<Label>(dialog,"cameraHelp").Text.Contains("first left click"),"Control descriptions follow the selected language");
                    Check(mode.SelectedIndex==1&&filter.SelectedIndex==21&&delta[1].Value==90,"Localization preserves mode, filter and angles");
                    typeof(Localizator).GetField("curLang",BindingFlags.Static|BindingFlags.NonPublic).SetValue(null,LangEnum.PL);
                    dialog.UpdateLanguage();
                    // Create native child handles off-screen and transparent for a real layout preview.
                    dialog.StartPosition=FormStartPosition.Manual;
                    dialog.Location=new Point(-32000,-32000);
                    dialog.Opacity=0;
                    dialog.Show();
                    dialog.PerformLayout();
                    Check(Field<GroupBox>(dialog,"controlsGroup").Bottom<=dialog.ClientSize.Height
                        &&Field<Label>(dialog,"bindingsHelp").Height>=Field<Label>(dialog,"bindingsHelp").PreferredHeight,
                        "Full controls fit the default window without clipping");
                    using(var bitmap=new Bitmap(dialog.Width,dialog.Height)){
                        dialog.DrawToBitmap(bitmap,new Rectangle(Point.Empty,dialog.Size));
                        bitmap.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"group-selection-window.png"),ImageFormat.Png);
                    }
                    dialog.Hide();
                    Click(Field<Button>(dialog,"undo"));Check(Test_GetUndo()==0,"Rotation undo");
                    Test_SetPlaying(1);dialog.RefreshState();
                    Check(!Field<Button>(dialog,"apply").Enabled&&!mode.Enabled&&!delta[0].Enabled,"Play mode blocks transforms");
                    Test_SetPlaying(0);dialog.RefreshState();Click(Field<Button>(dialog,"clear"));
                    Check(Field<Label>(dialog,"selectedCount").Text=="Zaznaczono: 0"&&!Field<Button>(dialog,"apply").Enabled,"Empty selection blocks apply");
                    SpacerNET.form=form;
                    using(var objects=new ObjTree()){
                        SpacerNET.objTreeWin=objects;
                        try {
                            var tree=objects.globalTree;
                            var quick=objects.quickTree;
                            var folder=new TreeNode("Folder"){Tag=Constants.TAG_FOLDER};
                            var a=new TreeNode("First (zCVobSpot)"){Tag=101u};
                            var b=new TreeNode("Second (zCVobSpot)"){Tag=102u};
                            var c=new TreeNode("Third (zCVobSpot)"){Tag=103u};
                            folder.Nodes.AddRange(new[]{a,b,c});tree.Nodes.Add(folder);folder.Expand();
                            var quickA=new TreeNode(a.Text){Tag=101u};quick.Nodes.Add(quickA);
                            objects.StartPosition=FormStartPosition.Manual;objects.Location=new Point(-32000,-32000);objects.Opacity=0;
                            objects.Show();objects.Location=new Point(-32000,-32000);objects.PerformLayout();
                            Call(form,"RefreshMultiSelectionWindow");
                            TreeClick(tree,a,0);TreeClick(tree,b,8); // MK_CONTROL
                            Check(Imports.Extern_GetMultiSelectionCount()==2&&GroupSelected(tree,a)&&GroupSelected(tree,b),"Objects tree Ctrl click adds and highlights both objects");
                            Check(Field<Label>(dialog,"selectedCount").Text=="Zaznaczono: 2","Objects tree updates group count immediately");
                            Check(Test_GetSingleSelectCalls()==0,"Group tree clicks do not invoke single selection");
                            TreeClick(tree,b,8);
                            Check(Imports.Extern_GetMultiSelectionCount()==2,"Repeated Ctrl click keeps an existing member");
                            TreeClick(tree,c,4); // MK_SHIFT
                            Check(Imports.Extern_GetMultiSelectionCount()==3&&GroupSelected(tree,c),"Shift click adds in Objects tree");
                            var groupClick=typeof(ObjTree).GetMethod("HandleGroupTreeClick",BindingFlags.Instance|BindingFlags.NonPublic);
                            groupClick.Invoke(objects,new object[]{tree,new Point(b.Bounds.Left+3,b.Bounds.Top+3),Keys.Alt,false});
                            Check(Imports.Extern_GetMultiSelectionCount()==2&&!GroupSelected(tree,b),"Alt removes only the clicked object");
                            Imports.Extern_ClearMultiSelection();Imports.Extern_ChangeMultiSelection(102,1);
                            Call(form,"RefreshMultiSelectionWindow");
                            Check(GroupSelected(tree,b)&&!GroupSelected(tree,a),"Viewport selection synchronizes to Objects tree");
                            int calls=Test_GetSelectionCalls();
                            groupClick.Invoke(objects,new object[]{tree,new Point(-5,-5),Keys.Control,false});
                            Check(Test_GetSelectionCalls()==calls,"Empty space does not change group selection");
                            TreeClick(tree,folder,8);
                            Check(Test_GetSelectionCalls()==calls,"Folder click does not clear the group");
                            int expanderX=-1;
                            for(int x=0;x<folder.Bounds.Left;++x)
                                if(tree.HitTest(x,folder.Bounds.Top+3).Location==TreeViewHitTestLocations.PlusMinus){expanderX=x;break;}
                            Check(expanderX>=0,"Folder expander exists");
                            var expander=new IntPtr(((folder.Bounds.Top+3)<<16)|expanderX);
                            SendMessage(tree.Handle,0x0201,new IntPtr(1),expander);SendMessage(tree.Handle,0x0202,IntPtr.Zero,expander);
                            Check(!folder.IsExpanded&&Test_GetSelectionCalls()==calls,"Expander collapses without changing the group");
                            folder.Expand();
                            Test_SetPlaying(1);TreeClick(tree,c,8);Test_SetPlaying(0);
                            Check(Test_GetSelectionCalls()==calls&&Imports.Extern_GetMultiSelectionCount()==1,"Play mode blocks tree selection edits");
                            TreeClick(tree,a,0);
                            Check(Imports.Extern_GetMultiSelectionCount()==1&&GroupSelected(tree,a)&&!GroupSelected(tree,b),"Plain tree click replaces the group");
                            TreeClick(tree,b,8);tree.SelectedNode=folder;
                            bool dark=Theme.IsDark;
                            try {
                                Theme.IsDark=true;ThemeApplier.Apply(objects);
                                Check(tree.DrawMode==TreeViewDrawMode.OwnerDrawText&&GroupSelected(tree,a)&&GroupSelected(tree,b),"Theme changes preserve group highlighting");
                                using(var bitmap=new Bitmap(objects.Width,objects.Height)){
                                    objects.DrawToBitmap(bitmap,new Rectangle(Point.Empty,objects.Size));
                                    bitmap.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"objects-list-group-selection.png"),ImageFormat.Png);
                                }
                            }finally {Theme.IsDark=dark;ThemeApplier.Apply(objects);}
                            tree.Sort();
                            Check(GroupSelected(tree,a)&&GroupSelected(tree,b),"Sorting keeps group membership by address");
                            tree.Nodes.Clear();
                            var rebuilt=new TreeNode("Rebuilt second"){Tag=102u};tree.Nodes.Add(rebuilt);
                            Call(form,"RefreshMultiSelectionWindow");
                            Check(GroupSelected(tree,rebuilt)&&Imports.Extern_GetMultiSelectionCount()==2,"Rebuilt tree nodes recover the existing group selection");
                            var tabs=Field<TabControl>(objects,"tabControlObjectList");tabs.SelectedIndex=1;
                            TreeClick(quick,quickA,8);
                            Check(GroupSelected(quick,quickA)&&GroupSelected(tree,rebuilt)&&Imports.Extern_GetMultiSelectionCount()==2,"Fast access shares the same group");
                            groupClick.Invoke(objects,new object[]{quick,new Point(quickA.Bounds.Left+3,quickA.Bounds.Top+3),Keys.Alt,false});
                            Check(!GroupSelected(quick,quickA)&&Imports.Extern_GetMultiSelectionCount()==1,"Fast access removes only its object");
                            multiButton.Checked=false;Call(form,"RefreshMultiSelectionWindow");
                            Check(tree.DrawMode==TreeViewDrawMode.Normal&&quick.DrawMode==TreeViewDrawMode.Normal&&!GroupSelected(tree,rebuilt),"Leaving group mode restores native tree rendering");
                            tabs.SelectedIndex=0;
                            var ordinary=new TreeNode("Ordinary third"){Tag=103u};tree.Nodes.Add(ordinary);
                            TreeClick(tree,ordinary,0);
                            Check(Test_GetSingleSelectCalls()>0,"Ordinary tree click retains single-object selection");
                            using(var vobWindow=new VobListForm())
                                Check(vobWindow.listBoxVobs.GetType()==typeof(ListBox)&&vobWindow.listBoxVobs.SelectionMode==SelectionMode.One,"Separate VOB List retains its original control and behavior");
                            multiButton.Checked=true;
                        }finally {SpacerNET.objTreeWin=null;ObjTree.previousSelectedNode=null;}
                    }
                    var closing=new FormClosingEventArgs(CloseReason.UserClosing,false);
                    typeof(Form).GetMethod("OnFormClosing",BindingFlags.NonPublic|BindingFlags.Instance).Invoke(dialog,new object[]{closing});
                    Check(closing.Cancel&&!dialog.IsDisposed&&!multiButton.Checked&&Test_GetWorkMode()==0,"Closing exits group mode and retains reusable window");
                }finally {
                    SpacerNET.form=null;
                    Field<System.Windows.Forms.Timer>(form,"multiSelectionTimer").Stop();
                    Field<System.Windows.Forms.Timer>(form,"multiSelectionTimer").Dispose();
                    Field<System.Windows.Forms.Timer>(form,"timerStatusBar").Stop();dialog.Dispose();
                }
            }
            Console.WriteLine("PASS: "+checks+" floating-window/native interop checks (hidden form, Polish locale)");
            return 0;
        }catch(Exception e){Console.Error.WriteLine(e);return 1;}
    }
}
