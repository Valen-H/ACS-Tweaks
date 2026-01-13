using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Newtonsoft.Json;
using XiaWorld;

namespace Acs_Tweaks {
	
	public class Acs_Tweaks {
		
		public static void OnInit() {
			GameDefine.MindStateChangeSpeeds.Clear();
			GameDefine.MindStateChangeSpeeds.Add(0, new float[] { .01f,  -.2f,   .01f,   -.2f });
			GameDefine.MindStateChangeSpeeds.Add(1, new float[] { .015f, -.1f,   .02f,   -.1f });
			GameDefine.MindStateChangeSpeeds.Add(2, new float[] { .1f,   -.1f,   .22f,   -.1f });
			GameDefine.MindStateChangeSpeeds.Add(3, new float[] { 0f,     -.04f,  .11f,   -.04f });
			GameDefine.MindStateChangeSpeeds.Add(4, new float[] { .001f, -.03f,  .15f,   -.03f });
			GameDefine.MindStateChangeSpeeds.Add(5, new float[] { 0f,     -.045f, .065f,  -.05f });
			GameDefine.MindStateChangeSpeeds.Add(6, new float[] { 0f,     -.02f,  .0075f, -.02f });
			GameDefine.MindStateChangeSpeeds.Add(7, new float[] { -.05f, -.1f,   0f,      -.14f });
			GameDefine.MindState2TreeExp.Clear();
			GameDefine.MindState2TreeExp.Add(0, .1f);
			GameDefine.MindState2TreeExp.Add(1, .22f);
			GameDefine.MindState2TreeExp.Add(2, .45f);
			GameDefine.MindState2TreeExp.Add(3, 1f);
			GameDefine.MindState2TreeExp.Add(4, 1.35f);
			GameDefine.MindState2TreeExp.Add(5, 1.7f);
			GameDefine.MindState2TreeExp.Add(6, 2.3f);
			GameDefine.MindState2TreeExp.Add(7, 3f);
			GameDefine.MindState2PracticeSpeed.Clear();
			GameDefine.MindState2PracticeSpeed.Add(0, .1f);
			GameDefine.MindState2PracticeSpeed.Add(1, .2f);
			GameDefine.MindState2PracticeSpeed.Add(2, .4f);
			GameDefine.MindState2PracticeSpeed.Add(3, 1f);
			GameDefine.MindState2PracticeSpeed.Add(4, 1.3f);
			GameDefine.MindState2PracticeSpeed.Add(5, 1.5f);
			GameDefine.MindState2PracticeSpeed.Add(6, 2f);
			GameDefine.MindState2PracticeSpeed.Add(7, 2.5f);
			GameDefine.MindState2Refining.Clear();
			GameDefine.MindState2Refining.Add(0, -2f);
			GameDefine.MindState2Refining.Add(1, -1f);
			GameDefine.MindState2Refining.Add(2, -.4f);
			GameDefine.MindState2Refining.Add(3, 0f);
			GameDefine.MindState2Refining.Add(4, .12f);
			GameDefine.MindState2Refining.Add(5, .3f);
			GameDefine.MindState2Refining.Add(6, .51f);
			GameDefine.MindState2Refining.Add(7, 1f);
			GameDefine.MindState2RefiningRate.Clear();
			GameDefine.MindState2RefiningRate.Add(0, .1f);
			GameDefine.MindState2RefiningRate.Add(1, .2f);
			GameDefine.MindState2RefiningRate.Add(2, .4f);
			GameDefine.MindState2RefiningRate.Add(3, 1f);
			GameDefine.MindState2RefiningRate.Add(4, 1.5f);
			GameDefine.MindState2RefiningRate.Add(5, 2f);
			GameDefine.MindState2RefiningRate.Add(6, 3f);
			GameDefine.MindState2RefiningRate.Add(7, 3.5f);
			GameDefine.MindState2UnderstandRate.Clear();
			GameDefine.MindState2UnderstandRate.Add(0, 0f);
			GameDefine.MindState2UnderstandRate.Add(1, .01f);
			GameDefine.MindState2UnderstandRate.Add(2, .1f);
			GameDefine.MindState2UnderstandRate.Add(3, 1f);
			GameDefine.MindState2UnderstandRate.Add(4, 1.5f);
			GameDefine.MindState2UnderstandRate.Add(5, 2.5f);
			GameDefine.MindState2UnderstandRate.Add(6, 4f);
			GameDefine.MindState2UnderstandRate.Add(7, 5.5f);
			GameDefine.MindState2BrokenNeck.Clear();
			GameDefine.MindState2BrokenNeck.Add(0, .1f);
			GameDefine.MindState2BrokenNeck.Add(1, .2f);
			GameDefine.MindState2BrokenNeck.Add(2, .4f);
			GameDefine.MindState2BrokenNeck.Add(3, 1f);
			GameDefine.MindState2BrokenNeck.Add(4, 1.3f);
			GameDefine.MindState2BrokenNeck.Add(5, 2f);
			GameDefine.MindState2BrokenNeck.Add(6, 3f);
			GameDefine.MindState2BrokenNeck.Add(7, 3.3f);
			GameDefine.MindState2GoldDan.Clear();
			GameDefine.MindState2GoldDan.Add(0, .3f);
			GameDefine.MindState2GoldDan.Add(1, .4f);
			GameDefine.MindState2GoldDan.Add(2, .6f);
			GameDefine.MindState2GoldDan.Add(3, 1f);
			GameDefine.MindState2GoldDan.Add(4, 1.3f);
			GameDefine.MindState2GoldDan.Add(5, 1.6f);
			GameDefine.MindState2GoldDan.Add(6, 2f);
			GameDefine.MindState2GoldDan.Add(7, 2.4f);
			GameDefine.MindState2Demon.Clear();
			GameDefine.MindState2Demon.Add(0, 2.5f);
			GameDefine.MindState2Demon.Add(1, 2f);
			GameDefine.MindState2Demon.Add(2, 1.4f);
			GameDefine.MindState2Demon.Add(3, 1f);
			GameDefine.MindState2Demon.Add(4, .65f);
			GameDefine.MindState2Demon.Add(5, .15f);
			GameDefine.MindState2Demon.Add(6, 0f);
			GameDefine.MindState2Demon.Add(7, 0f);
			GameDefine.SchoolShuiRankMap.Clear();
			GameDefine.SchoolShuiRankMap.Add(4f, g_emFengshuiRank.Best);
			GameDefine.SchoolShuiRankMap.Add(2.5f, g_emFengshuiRank.VeryGood);
			GameDefine.SchoolShuiRankMap.Add(1f, g_emFengshuiRank.Good);
			GameDefine.SchoolShuiRankMap.Add(-1f, g_emFengshuiRank.Bad);
			GameDefine.SchoolShuiRankMap.Add(-3.5f, g_emFengshuiRank.VeryBad);
			GameDefine.SchoolShuiRankMap.Add(-999f, g_emFengshuiRank.Worst);
			
			AccessTools.StaticFieldRefAccess<float>(typeof(LsStoneData), "_NeedT")		= 600f;
			
			KLog.Info("ACS Tweaks Loaded.");
		} //OnInit
		
		[HarmonyPatch]
		static class Nerf {
			
			[HarmonyPrefix]
			[HarmonyPatch(typeof(NpcPractice), nameof(NpcPractice.GetTreeExpNeed), new Type[] { typeof(int), typeof(int) })]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static bool GetTreeExpNeed(NpcPractice __instance, ref float __result, int dif, int yinyang) {
				int	attainment;
				
				if (__instance.Gong.YinYang == 0 || __instance.LogicStage < 10)
					attainment	= __instance.GetDaoHang(false);
				else if (yinyang == -1)
					attainment	= __instance.GetYinDaoHang(false);
				else if (yinyang == 1)
					attainment	= __instance.GetYangDaoHang(false);
				else
					attainment	= UnityEngine.Mathf.Min(__instance.GetYinDaoHang(false), __instance.GetYangDaoHang(false));
				
				__result		= dif * (3f + attainment * (attainment / 1.85f)) * (1f + GameEventMgr.Instance.GetCurDriver().TreeExpAddtion) * (1f - CangJingGeMgr.Instance.GetCangJingGeLearnBuff());
				
				return false;
			} //GetTreeExpNeed
			[HarmonyPostfix]
			[HarmonyPatch(typeof(EsotericaData), nameof(EsotericaData.GetRealDifficulty))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void EsotericaData_GetRealDifficulty(ref int __result) {
				__result	= UnityEngine.Mathf.CeilToInt(__result / 1.4f);
			} //EsotericaData_GetRealDifficulty
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(Npc), nameof(Npc.GetSpeed))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void Npc_GetSpeed(ref float __result) {
				__result++;
			} //Npc_GetSpeed
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(OutspreadMgr), nameof(OutspreadMgr.Policy_Interval_Scale), MethodType.Getter)]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void Policy_Interval_Scale(ref float __result) {
				__result		*= .6f;
			} //Policy_Interval_Scale
			
			[HarmonyPrefix]
			[HarmonyPatch(typeof(EffectMapData.MapEffectData), nameof(EffectMapData.MapEffectData.GetValue))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static bool MapEffectData_GetValue(EffectMapData.MapEffectData __instance, ref float __result, int tkey, float bvalue = 0f, bool checkroom = true, bool checktime = false) {
				if (bvalue == 0f)
					bvalue				= __instance.basevalue;
				
				AreaBase	areaBase	= null;
				
				if (checkroom)
					areaBase			= AreaMgr.Instance.CheckArea(tkey, "Room");
				
				for (int i = 0; i < __instance.effectsource.Count; i++) {
					if (__instance.effectsource[i] != null) {
						if (!checkroom || AreaMgr.Instance.CheckArea(__instance.effectsource[i].key, "Room") == areaBase)
							bvalue		+= __instance.effectsource[i].GetValue(tkey);
					}
				}
				
				if (!checktime) {
					__result			= bvalue * (1f + __instance.addp) + __instance.addv;
					return false;
				}
				
				__result				= (bvalue * (1f + __instance.addp) + __instance.addv) * UnityEngine.Mathf.Lerp(0f, 1f, (World.Instance.TolSecond - __instance.creattime) / 600f);
				return false;
			} //MapEffectData_GetValue
			
			[HarmonyPrefix]
			[HarmonyPatch(typeof(NpcPractice), nameof(NpcPractice.GetFiveBaseEfficiency), new Type[] { typeof(GongDef), typeof(Npc), typeof(g_emElementKind) })]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static bool GetFiveBaseEfficiency(ref float __result, GongDef g, Npc npc, g_emElementKind? kind = null) {
				int[]	fiveBaseNeed	= g.GetFiveBaseNeed();
				float[]	array			= new float[] {
					npc.PropertyMgr.Perception,
					npc.PropertyMgr.Physique,
					npc.PropertyMgr.Charisma,
					npc.PropertyMgr.Intelligence,
					npc.PropertyMgr.Luck,
				};
				float	low				= 0f,
						high			= 0f,
						bonus			= 0f;
				
				for (int i = 0; i < 5; i++) {
					float	num3		= array[i];
					int		num4		= fiveBaseNeed[i];
					
					if (num4 >= 0) {
						if (num3 > num4)
							high		+= num3 - num4;
						else
							low			+= num4 - num3;
					}
				}
				
				switch (kind == null ? g.ElementKind : kind.Value) {
					case g_emElementKind.None:
						bonus	= npc.GetPropertySecond("GongMatch_NoneAddV");
						break;
					case g_emElementKind.Jin:
						bonus	= npc.GetPropertySecond("GongMatch_JinAddV");
						break;
					case g_emElementKind.Mu:
						bonus	= npc.GetPropertySecond("GongMatch_MuAddV");
						break;
					case g_emElementKind.Shui:
						bonus	= npc.GetPropertySecond("GongMatch_ShuiAddV");
						break;
					case g_emElementKind.Huo:
						bonus	= npc.GetPropertySecond("GongMatch_HuoAddV");
						break;
					case g_emElementKind.Tu:
						bonus	= npc.GetPropertySecond("GongMatch_TuAddV");
						break;
				}
				
				__result	= UnityEngine.Mathf.Max(.4f, 1f - .15f * low + .05f * high + .25f * (low != 0f ? 0f : 1f)) + bonus;
				
				return false;
			} //GetFiveBaseEfficiency
			
			[HarmonyPrefix]
			[HarmonyPatch(typeof(JobFunc), nameof(JobFunc.GetThunderScale))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static bool GetThunderScale(ref float __result, Npc npc, float N) {
				float	penaltyFix2Cloud	= npc.PropertyMgr.Practice.GetPenaltyFix2Cloud();
				
				__result	= (1.2f - npc.PropertyMgr.Luck * .05f) * (1f + .12f * N) * (1f + penaltyFix2Cloud) * (1f + GameEventMgr.Instance.GetCurDriver().ThunderAddion);
				
				return false;
			} //GetThunderScale
			[HarmonyPrefix]
			[HarmonyPatch(typeof(NpcPractice), nameof(NpcPractice.GetPenaltyFix2Cloud))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static bool GetPenaltyFix2Cloud(NpcPractice __instance, ref float __result) {
				float	penalty	= __instance.GetPenalty(),
						num;
				
				if (penalty > 0f) {
					num			= .01f * UnityEngine.Mathf.Min(1f, penalty);
					
					if (penalty > 10f)
						num		+= .02f * UnityEngine.Mathf.Min(45f, penalty - 5f);
					if (penalty > 50f)
						num		+= .01f * UnityEngine.Mathf.Min(450f, penalty - 40f);
					if (penalty > 500f)
						num		+= .005f * (penalty - 500f);
				} else {
					num			= .005f * UnityEngine.Mathf.Max(-1f, penalty);
					
					if (penalty < -20f)
						num		+= .005f * UnityEngine.Mathf.Max(-40f, penalty + 20f);
					if (penalty < -50f)
						num		+= .0005f * UnityEngine.Mathf.Max(-450f, penalty + 50f);
					if (penalty < -500f)
						num		+= .0001f * (penalty + 500f);
				}
				
				__result	= UnityEngine.Mathf.Clamp(num, -.9f, float.MaxValue);
				
				return false;
			} //GetPenaltyFix2Cloud
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(CangJingGeMgr), MethodType.Constructor)]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void CangJingGeMgr_Ctor(object __instance) {
				var	field	= __instance.GetType().GetField("BOOK_SHELF_MEMORY", BindingFlags.Instance | BindingFlags.NonPublic);
				
				field?.SetValue(__instance, 200);
			} //CangJingGeMgr_Ctor
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(HumanoidEvolutionMgr), "GetThinkInterval")]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void GetThinkInterval(ref float __result) {
				__result	/= 2.5f;
			} //GetThinkInterval
			[HarmonyPrefix]
			[HarmonyPatch(typeof(HumanoidEvolutionMgr), "_NpcAddThink", new Type[] { typeof(Npc), typeof(HumanoidEvolutionMgr.ThinkFrag) })]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void NpcAddThink(HumanoidEvolutionMgr __instance, Npc npc) {
				__instance.RaceInfos.GetDef(npc.RaceDefName).MaxThink	= 999;
			} //NpcAddThink
			[HarmonyPostfix]
			[HarmonyPatch(typeof(HERaceInfoDef), MethodType.Constructor)]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void HERaceInfoDef(object __instance) {
				var	field	= __instance.GetType().GetField("MaxThink", BindingFlags.Public | BindingFlags.Instance);
				
				field?.SetValue(__instance, 999);
			} //HERaceInfoDef
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(GongStageNeck), MethodType.Constructor)]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void GongStageNeck_Ctor(object __instance) {
				var	field	= __instance.GetType().GetField("ExploreValue", BindingFlags.Public | BindingFlags.Instance);
				
				field?.SetValue(__instance, (float)field?.GetValue(__instance) / 3f);
			} //GongStageNeck_Ctor
			
			[HarmonyPrefix]
			[HarmonyPatch(typeof(NpcSkillData), nameof(NpcSkillData.AddSkillExp))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void AddSkillExp(ref float v) {
				v	+= 40;
				v	*= 2.4f;
				v	+= 200;
			} //AddSkillExp
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(PlacesMgr), nameof(PlacesMgr.GetCost))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void PlacesMgr_GetCost(ref float __result) {
				__result	/= 2f;
			} //PlacesMgr_GetCost
			
			[HarmonyTranspiler]
			[HarmonyPatch(typeof(JobLeave2Explore), "CheckWaitDie")]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static IEnumerable<CodeInstruction> CheckWaitDie(IEnumerable<CodeInstruction> instructions) {
				var	codes		= new List<CodeInstruction>(instructions);
				var	gong		= AccessTools.PropertyGetter(typeof(Npc), nameof(Npc.GongKind));
				var	ling		= AccessTools.PropertyGetter(typeof(Thing), nameof(Thing.MaxLing));
				var	rand		= AccessTools.Method(typeof(World), nameof(World.RandomRange), new Type[] { typeof(float), typeof(float), typeof(GMathUtl.RandomType) });
				var	add			= AccessTools.Method(typeof(Thing), nameof(Thing.AddLing));
				
				for (int i = 0; i < codes.Count; i++) {
					if (i < codes.Count - 16 &&
						codes[i].Calls(gong) &&
						(codes[i + 2].opcode == OpCodes.Beq || codes[i + 2].opcode == OpCodes.Beq_S) &&
						codes[i + 7].Calls(ling) &&
						codes[i + 9].LoadsConstant(.1f) &&
						codes[i + 10].LoadsConstant(.3f) &&
						codes[i + 12].Calls(rand) &&
						codes[i + 15].Calls(add)
					) {
						codes[i + 9].operand	= .001f;
						codes[i + 10].operand	= .008f;
						
						KLog.Dbg("JobLeave2Explore.CheckWaitDie Patched.");
						
						break;
					}
				}
				
				return codes;
			} //CheckWaitDie
			
			[HarmonyTranspiler]
			[HarmonyPatch(typeof(ToilBrokenNeck), "OnEnterToil")]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static IEnumerable<CodeInstruction> ToilBrokenNeck_OnEnterToil(IEnumerable<CodeInstruction> instructions) {
				var	codes		= new List<CodeInstruction>(instructions);
				var	thunder		= AccessTools.Field(typeof(GongStageNeck), nameof(GongStageNeck.ThunderValue));
				
				for (int i = 0; i < codes.Count; i++) {
					if (i < codes.Count - 8 &&
						codes[i].LoadsField(thunder) &&
						codes[i + 7].LoadsConstant(520000f)) {
						codes[i + 7].operand	= 400000f;
						
						KLog.Dbg("ToilBrokenNeck.OnEnterToil Patched.");
						
						break;
					}
				}
				
				return codes;
			} //ToilBrokenNeck_OnEnterToil
			
		} //Nerf
		
		[HarmonyPatch]
		static class Fixes {
			
			[HarmonyPrefix]
			[HarmonyPatch(typeof(JobMgr), "GetJobClass")]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static bool GetJobClass(ref JobBase __result, Dictionary<string, List<JobBase>> ___m_mapJobCache, string name) {
				if (___m_mapJobCache.TryGetValue(name, out List<JobBase> list) && list.Count > 0) {
					JobBase	jobBase	= list[list.Count - 1];
					
					list.RemoveAt(list.Count - 1);
					
					__result	= jobBase;
					
					return false;
				}
				
				JobDef	jobDef		= AccessTools.StaticFieldRefAccess<Dictionary<string, JobDef>>(typeof(JobMgr), "JobDefs")[name];
				Type	type		= null;
				string	typeName	= "XiaWorld." + jobDef.DriverClass;
				
				foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies()) {
					type	= assembly.GetType(typeName, false, true);
					
					if (type != null)
						break;
				}
				
				if (type == null)
					throw new TypeLoadException("Could not load Job type:\t" + typeName);
				
				__result	= (JobBase)Activator.CreateInstance(type);
				
				return false;
			} //GetJobClass
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(Npc), "InitDiscipleBehaviour")]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void InitDiscipleBehaviour(Npc __instance) {
				__instance.JobEngine.AddBehaviour(new BehaviourACSTrain(g_emBehaviourKind.Magic, g_emBehaviourWorkKind.None, 3));
			} //InitDiscipleBehaviour
			
		} //Fixes
		
	} //Acs_Tweaks
	
} //Acs_Tweaks

namespace XiaWorld {
	
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class JobACSTrain : JobBase {
		
		protected override void OnInit(params object[] objs) {
			KLog.Dbg("JobACSTrain.OnInit Called.");
		} //OnInit
		protected override void OnEnterJob(KStateQUnit unit) {
			KLog.Dbg("JobACSTrain.OnEnterJob Called.");
		} //OnEnterJob
		protected override void OnLeaveJob(KStateQUnit unit) {
			CMD?.FinishCommand(false, false, false);
			Worker.JumpOutFromBuilding(false);
			KLog.Dbg("JobACSTrain.OnLeaveJob Called.");
		} //OnLeaveJob
		
		protected override List<ToilBase> GetToilList() {
			BuildingThing	buildingThing	= ThingMgr.Instance.FindThingByID((int)CMD.WorkParam) as BuildingThing;
			List<ToilBase>	list			= new List<ToilBase>();
			int				num				= buildingThing.CheckWorkSpace(true);
			
			list.Add(new ToilLockWorkSpace(buildingThing, num, false));
			list.Add(ToilGoto.GotoThing(buildingThing, g_emPathEndMode.Touch, num, false, null));
			list.Add(new ToilJump2Building(buildingThing, num, false));
			list.Add(new ToilACSTrain());
			list.Add(new ToilJump2Building(null, 0, true));
			
			return list;
		} //GetToilList
		protected override void OnToilFinish(ToilBase toil, g_emJobToilState state) {
			KLog.Dbg("JobACSTrain.OnToilFinish Called.");
		} //OnToilFinish
		
		protected override bool OnCheckFaildCondition() {
			return true;
		} //OnCheckFaildCondition
		
	} //JobACSTrain
	
	public class BehaviourACSTrain : BehaviourBase {
		
		public BehaviourACSTrain(g_emBehaviourKind kind, g_emBehaviourWorkKind workkind, int MPriority) : base(kind, workkind, MPriority) { } //BehaviourACSTrain
		
		public override JobBase Check(Npc npc, int seachr = 10000, bool tryfind = false) {
			if (npc.HealthState != g_emNpcHealthState.Normal)
				return null;
			
			Command	command	= CommandMgr.Instance.FindCommandAtThing("ACSTrain", npc, npc);
			
			if (command != null)
				return JobMgr.Instance.CreateJob("JobACSTrain", command, new object[0]);
			
			return null;
		} //Check
		
	} //BehaviourACSTrain
	
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class CommandACSTrain : Command {
		
		protected override void OnInit(params object[] objs) {
			base.OnInit(objs);
			KLog.Dbg("CommandACSTrain.OnInit Called.");
		} //OnInit
		public override void OnAfterLoad() {
			KLog.Dbg("CommandACSTrain.OnAfterLoad Called.");
		} //OnAfterLoad
		protected override void OnFinished(bool did) {
			KLog.Dbg("CommandACSTrain.OnFinished Called.");
		} //OnFinished
		
		protected override bool CheckRemoveAble() {
			if (!(OwnerThing is Npc npc) || !npc.IsValid || !npc.IsDisciple)
				return true;
			
			return false;
		} //CheckRemoveAble
		protected override bool CouldBeFind(Npc npc) {
			Npc	npc2	= OwnerThing as Npc;
			
			if (!npc2.IsCorpse && !npc2.IsDeath && CouldBeFind(npc)) {
				BuildingThing	buildingThing	= npc.map.Things.FindBuilding(npc, 9999, "SkillPractice", 0, true, false, 0, 9999, null, null, true);
				
				if (buildingThing != null && npc.map.CheckPath(npc, buildingThing.Key, g_emPathEndMode.Touch, false, true, true) > 0) {
					WorkParam = buildingThing.ID;
					
					return true;
				}
			}
			
			return false;
		} //CouldBeFind
		
	} //CommandACSTrain
	
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class ToilACSTrain : ToilBase {
		
		public override string	ToilAnimation {
			get		=> "shuhua1";
		} //ToilAnimation
		
		[JsonProperty]
		protected float			costtime;
		
		public override string GetDesc()	=> TFMgr.Get("Train Skills"); //GetDesc
		public override string GetToilKey()	=> "acstrain"; //GetToilKey
		
		protected override void OnNpcStoryTrigger() {
			KLog.Dbg("ToilACSTrain.OnNpcStoryTrigger Called.");
		} //OnNpcStoryTrigger
		
		protected override void OnEnterToil(KStateQUnit unit) {
			KLog.Dbg("ToilACSTrain.OnEnterToil Called.");
			
			costtime	= 50;
		} //OnEnterToil
		protected override void OnStepToil(float dt, KStateQUnit unit) {
			SetProgress(unit.keeptime / costtime);
			
			if (unit.keeptime >= costtime) {
				m_bDid			= true;
				unit.IsFinished	= true;
			}
		} //OnStepToil
		protected override void OnLeaveToil(KStateQUnit unit) { } //OnLeaveToil
		
	} //ToilACSTrain
	
} //XiaWorld
