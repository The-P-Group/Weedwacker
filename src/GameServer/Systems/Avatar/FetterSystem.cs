﻿using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class FetterSystem
    {
        public const uint DEFAULT_STATE = (uint)FetterState.NOT_OPEN;
        public readonly FetterCharacterCardData CardData;
        public readonly FetterInfoData FetterInfoData; // General info
        public readonly SortedList<int, FetterStoryData> FetterStoryData; // fetterId
        public readonly SortedList<int, FettersData> FettersData; // fetterId
        public readonly SortedList<int, PhotographPosenameData> PhotographPosenameData; // fetterId
        public readonly SortedList<int, PhotographExpressionData> PhotographExpressionData; // fetterId
        public static readonly SortedList<int, AvatarFetterLevelData> FetterLevelData = GameData.AvatarFetterLevelDataMap; // level Friendship exp breakpoints
        public int FetterLevel { get; private set; } = 1;
        public int FetterExp { get; private set; } = 0;
        public SortedList<int, FetterData> FetterStates { get; private set; } = new();


        public FetterSystem(int avatarId)
        {
            CardData = GameServer.AvatarInfo[avatarId].CardData;
            FetterInfoData = GameServer.AvatarInfo[avatarId].FetterInfoData;
            FetterStoryData = GameServer.AvatarInfo[avatarId].FetterStoryData;
            FettersData = GameServer.AvatarInfo[avatarId].FettersData;
            PhotographPosenameData = GameServer.AvatarInfo[avatarId].PhotographPosenameData;
            PhotographExpressionData = GameServer.AvatarInfo[avatarId].PhotographExpressionData;

            FetterStates.Add(FetterInfoData.fetterId, new FetterData() { FetterId = (uint)FetterInfoData.fetterId, FetterState = DEFAULT_STATE });
            foreach(FetterStoryData storyData in FetterStoryData.Values)
            {
                FetterStates.Add(storyData.fetterId, new FetterData() { FetterId = (uint)storyData.fetterId, FetterState = DEFAULT_STATE });
            }
            foreach(FettersData fettersData in FettersData.Values)
            {
                FetterStates.Add(fettersData.fetterId, new FetterData() { FetterId = (uint)fettersData.fetterId, FetterState = (uint)fettersData.initialFetterState });
            }
            foreach (PhotographPosenameData poseData in PhotographPosenameData.Values)
            {
                FetterStates.Add(poseData.fetterId, new FetterData() { FetterId = (uint)poseData.fetterId, FetterState = DEFAULT_STATE });
            }
            foreach (PhotographExpressionData expressionData in PhotographExpressionData.Values)
            {
                FetterStates.Add(expressionData.fetterId, new FetterData() { FetterId = (uint)expressionData.fetterId, FetterState = DEFAULT_STATE });
            }
        }

        public async Task Initialize()
        {
            var allFetters = FetterStoryData.Values.Concat<FetterBaseClass>(FettersData.Values).Concat(PhotographPosenameData.Values).Concat(PhotographExpressionData.Values).Append(FetterInfoData);
            foreach (FetterBaseClass fetter in allFetters.Where(w => FetterStates[w.fetterId].FetterState == 1))
            {
                await EvaluateFetterState(fetter, true);
            }
            foreach (FetterBaseClass fetter in allFetters.Where(w => FetterStates[w.fetterId].FetterState == 2))
            {
                await EvaluateFetterState(fetter, false);
            }
        }

        private async Task<uint> EvaluateFetterState(FetterBaseClass fetter, bool openOrFinish) // Returns: fetterState
        {
            if (openOrFinish ? fetter.openConds.Length == 0 : fetter.finishConds.Length == 0)
            {
                FetterStates[fetter.fetterId] = new FetterData()
                {
                    FetterId = (uint)fetter.fetterId,
                    FetterState = ++FetterStates[fetter.fetterId].FetterState
                };              
            }
            else
            {
                var fetterProto = new FetterData() { FetterId = (uint)fetter.fetterId };
                int resultLength = openOrFinish ? fetter.openConds.Length : fetter.finishConds.Length;
                Task<bool>[] condEvaluation = new Task<bool>[resultLength];
                for (int i = 0; i < resultLength; i++)
                {
                    var cond = fetter.openConds[i];
                    condEvaluation[i] = EvaluateFetterCond(fetter.fetterId, cond);
                }
                bool[] condResult = await Task.WhenAll(condEvaluation);
                if (condResult.All(b => b == true))
                {
                    fetterProto.FetterState = ++FetterStates[fetter.fetterId].FetterState;
                    FetterStates[FetterInfoData.fetterId] = fetterProto;
                }
                else
                {
                    for (uint i = 0; i < condResult.Length; i++)
                    {
                        if (condResult[i])
                        {
                            fetterProto.CondIndexList.Add(i);
                        }
                    }
                }
            }
            return FetterStates[fetter.fetterId].FetterState;
        }
        private async Task<bool> EvaluateFetterCond(int fetterId, FetterCond cond)
        {
            switch (cond.condType)
            {
                case FetterCondType.FETTER_COND_NONE:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_AVATAR_LEVEL:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_AVATAR_PROMOTE_LEVEL:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_FETTER_LEVEL:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_FINISH_PARENT_QUEST:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_FINISH_QUEST:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_NOT_OPEN:
                    return FetterStates[fetterId].FetterState == (uint)FetterState.NOT_OPEN;
                case FetterCondType.FETTER_COND_PLAYER_BIRTHDAY:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_UNLOCK_TRANS_POINT:
                    //TODO
                    return false;
                default:
                    Logger.WriteErrorLine("Unkown fetter condition: " + cond.condType);
                    return false;
            }
        }
    }
}
