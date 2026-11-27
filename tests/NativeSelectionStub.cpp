#include <cstring>
#include <algorithm>
#include <vector>
static char setting[128]={};
static int filter=0,through=0,count=5,undoCount=0,playing=0,mode=0,workMode=3,lastAction=0;
static float offsets[3]={};
static float angles[3]={};
static std::vector<unsigned> selectedVobs={11,12,13,14,15};
static int singleSelectCalls=0,selectionCalls=0;
extern "C" {
void Stack_PushString(const char* key){strncpy_s(setting,key,_TRUNCATE);}
int Extern_GetSetting(){return strcmp(setting,"multiSelectionFilter")==0?filter:
    strcmp(setting,"multiSelectionThroughWalls")==0?through:
    strcmp(setting,"multiSelectionTransformMode")==0?mode:
    strcmp(setting,"bToggleWorkMode")==0?workMode:0;}
int Extern_GetMultiSelectionCount(){return count;}
int Extern_IsGameModActive(){return playing;}
int Extern_CanUndoSelectionMove(){return undoCount;}
void Extern_SetSetting(int value){if(strcmp(setting,"bToggleWorkMode")==0)workMode=value;}
void Extern_SetMultiSelectionTransformMode(int value){mode=value;}
void Extern_SetMultiSelectionFilter(int value){filter=value;}
void Extern_SetMultiSelectionThroughWalls(int value){through=value;}
int Extern_MoveSelectedVobs(float x,float y,float z){lastAction=0;offsets[0]=x;offsets[1]=y;offsets[2]=z;++undoCount;return count;}
int Extern_RotateSelectedVobs(float x,float y,float z){lastAction=1;angles[0]=x;angles[1]=y;angles[2]=z;++undoCount;return count;}
float Test_GetAngle(int axis){return angles[axis];}
int Test_GetMode(){return mode;}
int Test_GetWorkMode(){return workMode;}
int Test_GetLastAction(){return lastAction;}
int Extern_UndoSelectionMove(){if(!undoCount)return 0;--undoCount;return 1;}
void Extern_ClearMultiSelection(){selectedVobs.clear();count=0;}
int Extern_ChangeMultiSelection(unsigned vob,int action){
    ++selectionCalls;
    if(playing||!vob||action<0||action>2)return -1;
    if(action==0)selectedVobs.clear();
    auto found=std::find(selectedVobs.begin(),selectedVobs.end(),vob);
    if(action==2){if(found!=selectedVobs.end())selectedVobs.erase(found);}
    else if(found==selectedVobs.end())selectedVobs.push_back(vob);
    count=(int)selectedVobs.size();return count;
}
int Extern_GetMultiSelectionVobs(unsigned* vobs,int capacity){
    if(vobs&&capacity>0)
        for(int i=0;i<count&&i<capacity;++i)vobs[i]=selectedVobs[i];
    return count;
}
void Extern_SetVobListType(int){}
void Extern_SetVobPickFilter(int){}
void Extern_SelectVobSync(unsigned){++singleSelectCalls;}
void Extern_SelectVob(unsigned){++singleSelectCalls;}
int Test_GetSingleSelectCalls(){return singleSelectCalls;}
int Test_GetSelectionCalls(){return selectionCalls;}
float Test_GetOffset(int axis){return offsets[axis];}
int Test_GetFilter(){return filter;}
int Test_GetThrough(){return through;}
int Test_GetUndo(){return undoCount;}
void Test_SetPlaying(int value){playing=value;}
}
