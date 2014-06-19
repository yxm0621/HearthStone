﻿using Engine.Client;
using Engine.Utility;
using System;
using System.Collections.Generic;

namespace Engine.Server
{
    public static class ActionCode
    {
        #region"常数"
        /// <summary>
        /// 动作类型
        /// </summary>
        public enum ActionType
        {
            /// <summary>
            /// 使用武器
            /// </summary>
            UseWeapon,
            /// <summary>
            /// 使用随从
            /// </summary>
            UseMinion,
            /// <summary>
            /// 使用法术
            /// </summary>
            UseAbility,
            /// <summary>
            /// 使用奥秘
            /// </summary>
            UseSecret,
            /// <summary>
            /// 命中奥秘
            /// </summary>
            HitSecret,
            /// <summary>
            /// 命中事件
            /// </summary>
            HitEvent,
            /// <summary>
            /// 攻击处理
            /// </summary>
            Attack,
            /// <summary>
            /// 状态变化
            /// </summary>
            Status,
            /// <summary>
            /// 武器点数
            /// </summary>
            WeaponPoint,
            /// <summary>
            /// 改变数值
            /// </summary>
            Point,
            /// <summary>
            /// 治疗
            /// </summary>
            Health,
            /// <summary>
            /// 变形（效果）
            /// </summary>
            Transform,
            /// <summary>
            /// 召唤
            /// </summary>
            Summon,
            /// <summary>
            /// 控制
            /// </summary>
            Control,
            /// <summary>
            /// 水晶
            /// </summary>
            Crystal,
            /// <summary>
            /// 卡牌
            /// </summary>
            Card,
            /// <summary>
            /// 结算
            /// </summary>
            Settle,
            /// <summary>
            /// 直接攻击
            /// </summary>
            Fight,
            /// <summary>
            /// 结束TURN
            /// </summary>
            EndTurn,
            /// <summary>
            /// 未知
            /// </summary>
            UnKnown
        }
        /// <summary>
        /// 变形（效果）
        /// </summary>
        public const string strTransform = "TRANSFORM";
        /// <summary>
        /// 召唤
        /// </summary>
        public const string strSummon = "SUMMON";
        /// <summary>
        /// 水晶
        /// </summary>
        public const string strCrystal = "CRYSTAL";
        /// <summary>
        /// 卡牌
        /// </summary>
        public const string strCard = "CARD";
        /// <summary>
        /// 攻击
        /// </summary>
        public const string strAttack = "ATTACK";
        /// <summary>
        /// 治疗
        /// </summary>
        public const string strHealth = "HEALTH";
        /// <summary>
        /// 改变状态
        /// </summary>
        public const string strStatus = "STATUS";
        /// <summary>
        /// 改变数值
        /// </summary>
        public const string strPoint = "POINT";
        /// <summary>
        /// 武器
        /// </summary>
        public const string strWeapon = "WEAPON";
        /// <summary>
        /// 随从
        /// </summary>
        public const string strMinion = "MINION";
        /// <summary>
        /// 法术
        /// </summary>
        public const string strAbility = "ABILITY";
        /// <summary>
        /// 武器
        /// </summary>
        public const string strWeaponPoint = "WEAPONPOINT";
        /// <summary>
        /// 控制
        /// </summary>
        public const string strControl = "CONTROL";
        /// <summary>
        /// 奥秘(埋伏)
        /// </summary>
        public const string strSecret = "SECRET";
        /// <summary>
        /// 奥秘(埋伏)
        /// </summary>
        public const string strHitSecret = "HITSECRET";
        /// <summary>
        /// 
        /// </summary>
        public const string strHitEvent = "HITEVENT";
        /// <summary>
        /// 战斗
        /// </summary>
        public const string strFight = "FIGHT";
        /// <summary>
        /// ENDTURN
        /// </summary>
        public const String strSettle = "SETTLE";
        /// <summary>
        /// ENDTURN
        /// </summary>
        public const String strEndTurn = "ENDTURN";
        /// <summary>
        /// 随从死亡
        /// </summary>
        public const String strDead = "DEAD";

        /// <summary>
        /// 获得类型
        /// </summary>
        public static ActionType GetActionType(String ActionWord)
        {
            ActionType t = ActionType.UnKnown;
            //动作
            if (ActionWord.StartsWith(strWeapon + CardUtility.strSplitMark)) t = ActionType.UseWeapon;
            if (ActionWord.StartsWith(strMinion + CardUtility.strSplitMark)) t = ActionType.UseMinion;
            if (ActionWord.StartsWith(strAbility + CardUtility.strSplitMark)) t = ActionType.UseAbility;
            //服务器不发送具体奥秘内容
            if (ActionWord.Equals(strSecret)) t = ActionType.UseSecret;
            if (ActionWord.StartsWith(strHitSecret + CardUtility.strSplitMark)) t = ActionType.HitSecret;
            if (ActionWord.StartsWith(strHitEvent + CardUtility.strSplitMark)) t = ActionType.HitEvent;

            if (ActionWord.StartsWith(strFight + CardUtility.strSplitMark)) t = ActionType.Fight;
            if (ActionWord.Equals(strSettle)) t = ActionType.Settle;
            if (ActionWord.Equals(strEndTurn)) t = ActionType.EndTurn;
            //效果
            if (ActionWord.StartsWith(strTransform + CardUtility.strSplitMark)) t = ActionType.Transform;
            if (ActionWord.StartsWith(strAttack + CardUtility.strSplitMark)) t = ActionType.Attack;
            if (ActionWord.StartsWith(strStatus + CardUtility.strSplitMark)) t = ActionType.Status;
            if (ActionWord.StartsWith(strHealth + CardUtility.strSplitMark)) t = ActionType.Health;
            if (ActionWord.StartsWith(strCrystal + CardUtility.strSplitMark)) t = ActionType.Crystal;
            if (ActionWord.StartsWith(strSummon + CardUtility.strSplitMark)) t = ActionType.Summon;
            if (ActionWord.StartsWith(strCard + CardUtility.strSplitMark)) t = ActionType.Card;
            if (ActionWord.StartsWith(strPoint + CardUtility.strSplitMark)) t = ActionType.Point;
            if (ActionWord.StartsWith(strControl + CardUtility.strSplitMark)) t = ActionType.Control;
            if (ActionWord.StartsWith(strWeaponPoint + CardUtility.strSplitMark)) t = ActionType.WeaponPoint;
            
            return t;
        }

        #endregion

    }
}
