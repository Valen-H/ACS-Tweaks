using HarmonyLib;

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

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
			
			KLog.Dbg("ACS Tweaks Loaded.");
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
				
				__result		= dif * (1f + attainment * (attainment / 2f)) * (1f + GameEventMgr.Instance.GetCurDriver().TreeExpAddtion) * (1f - CangJingGeMgr.Instance.GetCangJingGeLearnBuff());
				
				return false;
			} //GetTreeExpNeed
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(Npc), nameof(Npc.GetSpeed))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void GetSpeed(ref float __result) {
				__result++;
			} //GetSpeed
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(OutspreadMgr), nameof(OutspreadMgr.Policy_Interval_Scale), MethodType.Getter)]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void Policy_Interval_Scale(ref float __result) {
				__result		*= .6f;
			} //Policy_Interval_Scale
			
			[HarmonyPrefix]
			[HarmonyPatch(typeof(EffectMapData.MapEffectData), nameof(EffectMapData.MapEffectData.GetValue))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static bool GetValue(EffectMapData.MapEffectData __instance, ref float __result, int tkey, float bvalue = 0f, bool checkroom = true, bool checktime = false) {
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
			} //GetValue
			
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
			[HarmonyPatch(typeof(EsotericaData), nameof(EsotericaData.GetRealDifficulty))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void GetRealDifficulty(ref int __result) {
				__result	= UnityEngine.Mathf.RoundToInt(__result / 1.4f);
			} //GetRealDifficulty
			
			[HarmonyPostfix]
			[HarmonyPatch(typeof(CangJingGeMgr), MethodType.Constructor)]
			[MethodImpl(MethodImplOptions.NoInlining)]
			static void CangJingGeMgr_Ctor(object __instance) {
				var	field	= __instance.GetType().GetField("BOOK_SHELF_MEMORY", BindingFlags.Instance | BindingFlags.NonPublic);
				
				field?.SetValue(__instance, 200);
			} //CangJingGeMgr_Ctor
			
		} //Nerf
		
	} //Acs_Tweaks
	
} //Acs_Tweaks
