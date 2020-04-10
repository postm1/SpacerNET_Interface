using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class ObjectsWindow : Form
    {
        public ObjectsWindow()
        {
            InitializeComponent();
            
        }

        static int maxDepth = 0;
        static int lastNumber = 0;

        static TreeNode last = null;


        public static void FindClass(TreeNodeCollection nodes, string baseClass, string name)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Text == baseClass)
                {
                    nodes[i].Nodes.Add(name);
                    return;
                }

                FindClass(nodes[i].Nodes, baseClass, name);
            }
        }

        [DllExport]
        public static void AddClassNode(IntPtr ptr, int depth, IntPtr ptrB)
        {
            string name = Marshal.PtrToStringAnsi(ptr);
            string baseClassName = Marshal.PtrToStringAnsi(ptrB);
            TreeNodeCollection nodes = UnionNET.objWin.classesTreeView.Nodes;


            //nodes.Add(name + " (" + depth.ToString() + ") " + baseClassName);

            Console.WriteLine(" Class: " + name + " (" + baseClassName + ")");

            if (name == baseClassName)
            {
                nodes.Add(name);
                return;
            }

            

            FindClass(nodes, baseClassName, name);


            /*
            for (int i = 0; i < nodes.Count; i++)
            {
                TreeNode node = nodes[i];

                for (int j = 0)

                Console.WriteLine(node.Text + " Class: " + name + " (" + baseClassName + ")");
                
                if (node.Text == baseClassName)
                {
                  
                    node.Nodes.Add(name);
                    break;
                }
                else
                {
                    //nodes.Add(name);
                    //break;
                }
            }
            */

            Console.WriteLine("==========");

            /*
             * for (int i = 0; i < count; i ++) {
                var some = somes[i];
                str parrentClassName = some.parrentClassName;
                str nameOfClass = some.nameOfClass;
                if (!parrentClassName.length) {
                    nodes.add(some);
                } else {
                    var node = search(parrentClassName);
                    node.add(some);
                }
            }
             * 
             * 
             * 
             * 
             * 
             */

            //TreeNode node = new TreeNode(name + " >> (" + depth.ToString() + ")");

            //nodes.Insert(depth, node);

            /*
        if (maxDepth < depth || nodes.Count == 0)
        {
            nodes.Add(name + " >>  (" + depth.ToString() + ")");
            maxDepth++;
        }
        else
        {
            nodes[depth-1].Nodes.Add(name + " (" + depth.ToString() + ")");

        }
        */

            lastNumber++;


            //UnionNET.objWin.classesTreeView.Nodes.
            //Marshal.FreeHGlobal(ptr);

            UnionNET.objWin.classesTreeView.ExpandAll();
        }
    }
}
