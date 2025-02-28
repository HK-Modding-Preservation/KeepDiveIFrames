using Modding                                                                                                   ;
using System.Collections.Generic                                                                                ;
using UnityEngine                                                                                               ;
using Satchel                                                                                                   ;
namespace KeepDiveIFrames                                                                                       {
    public class KeepDiveIFrames: Mod                                                                           {
        new public string GetName() => "KeepDiveIFrames"                                                        ;
        public override string GetVersion() => "1.0.0.1"                                                        ;
        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)    {
            On.PlayMakerFSM.OnEnable += editFSM                                                                 ;}
        private void editFSM(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)                             {
            orig(self)                                                                                          ;
            if(self.gameObject.name == "Knight" && self.FsmName == "Spell Control")                             {
                self.GetValidState("Quake Antic").RemoveAction(1)                                               ;}}}}