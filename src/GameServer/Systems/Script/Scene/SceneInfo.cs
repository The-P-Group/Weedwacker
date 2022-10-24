﻿using System.Text.RegularExpressions;
using NLua;
using Vim.Math3d;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneInfo
    {
        Lua LuaState;
        public SceneConfig? scene_config;

        public SortedList<int, int>? blocks; // <index ,blockIds>
        public SortedList<int, SceneBlock>? BlocksInfo; // blockId
        public SortedList<int, Rectangle>? block_rects = new(); // <index, rectangle>
        public LuaTable dummy_points;// => LuaState.GetTable("dummy_points"); // load dummy points from Scene<sceneId>_<string>.lua
        public LuaTable routes_config;// => LuaState.GetTable("routes_config"); // load routes from ???
        
        public static Task<SceneInfo> CreateAsync(Lua lua, int sceneId, string scriptPath)
        {
            var scene = new SceneInfo();
            return scene.InitializeAsync(lua, sceneId, scriptPath);
        }

        private async Task<SceneInfo> InitializeAsync(Lua lua, int sceneId, string scriptPath)
        {
            LuaState = lua;
            FileInfo commonInfo = new(Path.Combine(scriptPath, "Config", "Excel", "CommonScriptConfig.lua"));
            string common = commonInfo.FullName;
            common = Regex.Replace(common, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString($"_SCENE{sceneId} = {{}}");
            lua.DoString("loadCommon = loadfile (\"" + common + "\"" + $", \"bt\")");
            lua.DoString("loadCommon()");
            FileInfo configEntityInfo = new(Path.Combine(scriptPath, "Config", "Json", "ConfigEntity.lua"));
            string configEntity = configEntityInfo.FullName;
            configEntity = Regex.Replace(configEntity, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString($"_SCENE{sceneId} = {{}}");
            lua.DoString("loadConfigEntity = loadfile (\"" + configEntity + "\"" + $", \"bt\")");
            lua.DoString("loadConfigEntity()");
            FileInfo configEntityTypeInfo = new(Path.Combine(scriptPath, "Config", "Json", "ConfigEntityType.lua"));
            string configEntityType = configEntityTypeInfo.FullName;
            configEntityType = Regex.Replace(configEntityType, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString($"_SCENE{sceneId} = {{}}");
            lua.DoString("loadConfigEntityType = loadfile (\"" + configEntityType + "\"" + $", \"bt\")");
            lua.DoString("loadConfigEntityType()");
            FileInfo configQuestTypeInfo = new(Path.Combine(scriptPath, "Config", "Json", "ConfigQuestType.lua"));
            string configQuestType = configQuestTypeInfo.FullName;
            configQuestType = Regex.Replace(configQuestType, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString($"_SCENE{sceneId} = {{}}");
            lua.DoString("loadQuestType = loadfile (\"" + configQuestType + "\"" + $", \"bt\")");
            lua.DoString("loadQuestType()");
            FileInfo sceneInfo = new(Path.Combine(scriptPath, "Scene", $"{sceneId}", $"scene{sceneId}.lua"));
            string sceneScript = sceneInfo.FullName;
            sceneScript = Regex.Replace(sceneScript, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString($"_SCENE{sceneId} = {{}}");
            lua.DoString("loadScene = loadfile (\"" + sceneScript + "\""+ $", \"bt\" , _SCENE{sceneId})");
            lua.DoString("loadScene()");
            if(lua[$"_SCENE{sceneId}.{nameof(scene_config)}"] != null)
                scene_config = new(lua.GetTable($"_SCENE{sceneId}.{nameof(scene_config)}"));
            if (lua[$"_SCENE{sceneId}.{nameof(blocks)}"] != null)
            {
                var bloks = lua.GetTable($"_SCENE{sceneId}.{nameof(blocks)}");
                blocks = new SortedList<int, int>(lua.GetTableDict(bloks).ToDictionary(w => (int)(long)w.Key, w => (int)(long)w.Value));
                BlocksInfo = new();
                foreach (int blockId in blocks.Values)
                {
                    //BlocksInfo.Add(blockId, await SceneBlock.CreateAsync(lua, sceneId, blockId, Path.Combine(scriptPath, "Scene", $"{sceneId}")));
                }
            }
            if (lua[$"_SCENE{sceneId}.{nameof(block_rects)}"] != null)
            {
                var rects = lua.GetTable($"_SCENE{sceneId}.{nameof(block_rects)}");
                var rectDict = lua.GetTableDict(rects);
                block_rects = new SortedList<int, Rectangle>(rectDict.ToDictionary(w => (int)(long)w.Key, w => new Rectangle(w.Value as LuaTable)));
            }

            return this;
        }

        public class SceneConfig
        {
            private LuaTable Table;
            // ONLY X,Z
            public Vector3 begin_pos => new Vector3((float?)(double?)Table[$"{nameof(begin_pos)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(begin_pos)}.z"] ?? 0);
            // ONLY X,Z
            public Vector3 size => new Vector3((float?)(double?)Table[$"{nameof(size)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(begin_pos)}.z"] ?? 0);
            public Vector3 born_pos => new Vector3((float?)(double?)Table[$"{nameof(born_pos)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(born_pos)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(born_pos)}.z"] ?? 0);
            public Vector3 born_rot => new Vector3((float?)(double?)Table[$"{nameof(born_rot)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(born_rot)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(born_rot)}.z"] ?? 0);
            public float? die_y => (int?)(long?)Table[$"die_y"];
            public RoomInfo room_safe_pos;
            // ONLY X,Z
            public Vector3 vision_anchor => new Vector3((float?)(double?)Table[$"{nameof(vision_anchor)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(vision_anchor)}.z"] ?? 0);

            public SceneConfig(LuaTable table)
            {
                Table = table;
                room_safe_pos = new(Table);
            }
        }

        public class Rectangle
        {
            private LuaTable Table;
            // ONLY X,Z
            public Vector3 min => new Vector3((float?)(double?)Table[$"{nameof(min)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(min)}.z"] ?? 0);
            // ONLY X,Z
            public Vector3 max => new Vector3((float?)(double?)Table[$"{nameof(max)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(max)}.z"] ?? 0);

            public Rectangle(LuaTable table)
            {
                Table = table;
            }
        }

        public class RoomInfo
        {
            private LuaTable Table;
            public int? scene_id => (int?)(long?)Table[$"{nameof(scene_id)}"] ?? 0;
            public Vector3 safe_pos => new Vector3((float?)(double?)Table[$"{nameof(safe_pos)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(safe_pos)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(safe_pos)}.z"] ?? 0);
            public Vector3 safe_rot => new Vector3((float?)(double?)Table[$"{nameof(safe_rot)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(safe_rot)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(safe_rot)}.z"] ?? 0);

            public RoomInfo(LuaTable table)
            {
                Table = table[$"{nameof(SceneConfig.room_safe_pos)}"] as LuaTable;
            }
        }
    }
}
