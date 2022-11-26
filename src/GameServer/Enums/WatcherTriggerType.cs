﻿namespace Weedwacker.GameServer.Enums
{
    internal enum WatcherTriggerType
    {
        TRIGGER_NONE = 0,
        TRIGGER_COMBAT_CONFIG_COMMON = 1,
        TRIGGER_ELEMENT_VIEW = 2,
        TRIGGER_ENTER_AIRFLOW = 5,
        TRIGGER_NEW_MONSTER = 6,
        TRIGGER_NEW_AFFIX = 8,
        TRIGGER_CHANGE_INPUT_DEVICE_TYPE = 9,
        TRIGGER_PAIMON_ANGRY_VOICE_EASTER_EGG = 10,
        TRIGGER_WIND_CRYSTAL = 11,
        TRIGGER_ELEMENT_BALL = 101,
        TRIGGER_WORLD_LEVEL_UP = 102,
        TRIGGER_DUNGEON_ENTRY_TO_BE_EXPLORED = 103,
        TRIGGER_UNLOCK_GATE_TEMPLE = 104,
        TRIGGER_UNLOCK_AREA = 105,
        TRIGGER_UNLOCK_TRANS_POINT = 106,
        TRIGGER_OPEN_CHEST_WITH_GADGET_ID = 107,
        TRIGGER_CITY_LEVEL_UP = 108,
        TRIGGER_MONSTER_DIE = 109,
        TRIGGER_PLATFORM_START_MOVE = 110,
        TRIGGER_GROUP_NOTIFY = 111,
        TRIGGER_ELEMENT_TYPE_CHANGE = 112,
        TRIGGER_GADGET_INTERACTABLE = 113,
        TRIGGER_COLLECT_SET_OF_READINGS = 114,
        TRIGGER_TELEPORT_WITH_CERTAIN_PORTAL = 115,
        TRIGGER_WORLD_GATHER = 116,
        TRIGGER_TAKE_GENERAL_REWARD = 117,
        TRIGGER_BATTLE_FOR_MONSTER_DIE_OR = 118,
        TRIGGER_BATTLE_FOR_MONSTER_DIE_AND = 119,
        TRIGGER_OPEN_WORLD_CHEST = 120,
        TRIGGER_ENTER_CLIMATE_AREA = 121,
        TRIGGER_UNLOCK_SCENE_POINT = 122,
        TRIGGER_INTERACT_GADGET_WITH_INTERACT_ID = 123,
        TRIGGER_OBTAIN_AVATAR = 201,
        TRIGGER_PLAYER_LEVEL = 202,
        TRIGGER_AVATAR_UPGRADE = 203,
        TRIGGER_AVATAR_PROMOTE = 204,
        TRIGGER_WEAPON_UPGRADE = 205,
        TRIGGER_WEAPON_PROMOTE = 206,
        TRIGGER_RELIQUARY_UPGRADE = 207,
        TRIGGER_WEAR_RELIQUARY = 208,
        TRIGGER_UPGRADE_TALENT = 209,
        TRIGGER_UNLOCK_RECIPE = 210,
        TRIGGER_RELIQUARY_SET_NUM = 211,
        TRIGGER_OBTAIN_MATERIAL_NUM = 212,
        TRIGGER_OBTAIN_RELIQUARY_NUM = 213,
        TRIGGER_GACHA_NUM = 214,
        TRIGGER_ANY_RELIQUARY_UPGRADE = 215,
        TRIGGER_FETTER_LEVEL_AVATAR_NUM = 216,
        TRIGGER_SKILLED_AT_RECIPE = 217,
        TRIGGER_RELIQUARY_UPGRADE_EQUAL_RANK_LEVEL = 218,
        TRIGGER_SPECIFIED_WEAPON_UPGRADE = 219,
        TRIGGER_SPECIFIED_WEAPON_AWAKEN = 220,
        TRIGGER_UNLOCK_SPECIFIC_RECIPE_OR = 221,
        TRIGGER_POSSESS_MATERIAL_NUM = 222,
        TRIGGER_EXHIBITION_ACCUMULABLE_VALUE = 223,
        TRIGGER_EXHIBITION_REPLACEABLE_VALUE_SETTLE_NUM = 224,
        TRIGGER_ANY_WEAPON_UPGRADE_NUM = 225,
        TRIGGER_ANY_RELIQUARY_UPGRADE_NUM = 226,
        TRIGGER_ACTIVITY_SCORE_EXCEED_VALUE = 227,
        TRIGGER_UNLOCK_SPECIFIC_FORGE_OR = 228,
        TRIGGER_UNLOCK_SPECIFIC_ANIMAL_CODEX = 229,
        TRIGGER_OBTAIN_ITEM_NUM = 230,
        TRIGGER_CAPTURE_ANIMAL = 231,
        TRIGGER_DAILY_TASK = 301,
        TRIGGER_RAND_TASK = 302,
        TRIGGER_AVATAR_EXPEDITION = 303,
        TRIGGER_FINISH_TOWER_LEVEL = 304,
        TRIGGER_WORLD_BOSS_REWARD = 306,
        TRIGGER_FINISH_DUNGEON = 307,
        TRIGGER_START_AVATAR_EXPEDITION = 308,
        TRIGGER_OPEN_BLOSSOM_CHEST = 309,
        TRIGGER_FINISH_BLOSSOM_PROGRESS = 310,
        TRIGGER_DONE_TOWER_GADGET_UNHURT = 311,
        TRIGGER_DONE_TOWER_STARS = 312,
        TRIGGER_DONE_TOWER_UNHURT = 313,
        TRIGGER_STEAL_FOOD_TIMES = 314,
        TRIGGER_DONE_DUNGEON_WITH_SAME_ELEMENT_AVATARS = 315,
        TRIGGER_GROUP_FLIGHT_CHALLENGE_REACH_POINTS = 316,
        TRIGGER_FINISH_DAILY_DELIVERY_NUM = 317,
        TRIGGER_TOWER_STARS_NUM = 318,
        TRIGGER_FINISH_SPECIFED_TYPE_BLOSSOM_NUM = 319,
        TRIGGER_FINISH_SPECIFED_TYPE_BLOSSOM_CLIMATE_METER = 320,
        TRIGGER_FINISH_BLOSSOM_GROUP_VARIABLE_GT = 321,
        TRIGGER_EFFIGY_CHALLENGE_SCORE = 322,
        TRIGGER_FINISH_ROUTINE = 323,
        TRIGGER_ACTIVITY_EXPEDITION_FINISH = 324,
        TRIGGER_ACTIVITY_CHANNELLER_SLAB_FINISH_ALL_CAMP = 325,
        TRIGGER_ACTIVITY_CHANNELLER_SLAB_FINISH_ALL_ONEOFF_DUNGEON = 326,
        TRIGGER_ACTIVITY_CHANNELLER_SLAB_LOOP_DUNGEON_TOTAL_SCORE = 327,
        TRIGGER_GROUP_SUMMER_TIME_SPRINT_BOAT_REACH_POINTS = 328,
        TRIGGER_WEEKLY_BOSS_KILL = 329,
        TRIGGER_BOUNCE_CONJURING_FINISH_COUNT = 330,
        TRIGGER_BOUNCE_CONJURING_SCORE = 331,
        TRIGGER_GROUP_VARIABLE_SET_VALUE_TO = 332,
        TRIGGER_KILL_GADGETS_BY_SPECIFIC_SKILL = 333,
        TRIGGER_KILL_MONSTERS_WITHOUT_VEHICLE = 334,
        TRIGGER_KILL_MONSTER_IN_AREA = 335,
        TRIGGER_ENTER_VEHICLE = 336,
        TRIGGER_VEHICLE_DURATION = 337,
        TRIGGER_VEHICLE_FRIENDS = 338,
        TRIGGER_VEHICLE_KILLED_BY_MONSTER = 339,
        TRIGGER_VEHICLE_DASH = 340,
        TRIGGER_DO_COOK = 401,
        TRIGGER_DO_FORGE = 402,
        TRIGGER_DO_COMPOUND = 403,
        TRIGGER_DO_COMBINE = 404,
        TRIGGER_BUY_SHOP_GOODS = 405,
        TRIGGER_FORGE_WEAPON = 406,
        TRIGGER_MP_PLAY_BATTLE_WIN = 421,
        TRIGGER_KILL_GROUP_MONSTER = 422,
        TRIGGER_CRUCIBLE_ELEMENT_SCORE = 423,
        TRIGGER_MP_DUNGEON_TIMES = 424,
        TRIGGER_MP_KILL_MONSTER_NUM = 425,
        TRIGGER_CRUCIBLE_MAX_BALL = 426,
        TRIGGER_CRUCIBLE_MAX_SCORE = 427,
        TRIGGER_CRUCIBLE_SUBMIT_BALL = 428,
        TRIGGER_CRUCIBLE_WORLD_LEVEL_SCORE = 429,
        TRIGGER_MP_PLAY_GROUP_STATISTIC = 430,
        TRIGGER_KILL_GROUP_SPECIFIC_MONSTER = 431,
        TRIGGER_REACH_MP_PLAY_SCORE = 432,
        TRIGGER_REACH_MP_PLAY_RECORD = 433,
        TRIGGER_TREASURE_MAP_DONE_REGION = 434,
        TRIGGER_SEA_LAMP_MINI_QUEST = 435,
        TRIGGER_FINISH_FIND_HILICHURL_LEVEL = 436,
        TRIGGER_COMBINE_ITEM = 437,
        TRIGGER_FINISH_CHALLENGE_IN_DURATION = 438,
        TRIGGER_FINISH_CHALLENGE_LEFT_TIME = 439,
        TRIGGER_MP_KILL_MONSTER_ID_NUM = 440,
        TRIGGER_LOGIN = 501,
        TRIGGER_COST_MATERIAL = 502,
        TRIGGER_DELIVER_ITEM_TO_SALESMAN = 503,
        TRIGGER_USE_ITEM = 504,
        TRIGGER_ACCUMULATE_DAILY_LOGIN = 505,
        TRIGGER_FINISH_CHALLENGE = 601,
        TRIGGER_MECHANICUS_UNLOCK_GEAR = 602,
        TRIGGER_MECHANICUS_LEVELUP_GEAR = 603,
        TRIGGER_MECHANICUS_DIFFICULT = 604,
        TRIGGER_MECHANICUS_DIFFICULT_SCORE = 605,
        TRIGGER_MECHANICUS_KILL_MONSTER = 606,
        TRIGGER_MECHANICUS_BUILDING_POINT = 607,
        TRIGGER_MECHANICUS_DIFFICULT_EQ = 608,
        TRIGGER_MECHANICUS_BATTLE_END = 609,
        TRIGGER_MECHANICUS_BATTLE_END_EXCAPED_LESS_THAN = 610,
        TRIGGER_MECHANICUS_BATTLE_END_POINTS_MORE_THAN = 611,
        TRIGGER_MECHANICUS_BATTLE_END_GEAR_MORE_THAN = 612,
        TRIGGER_MECHANICUS_BATTLE_END_PURE_GEAR_DAMAGE = 613,
        TRIGGER_MECHANICUS_BATTLE_END_CARD_PICK_MORE_THAN = 614,
        TRIGGER_MECHANICUS_BATTLE_END_CARD_TARGET_MORE_THAN = 615,
        TRIGGER_MECHANICUS_BATTLE_END_BUILD_GEAR_MORE_THAN = 616,
        TRIGGER_MECHANICUS_BATTLE_END_GEAR_KILL_MORE_THAN = 617,
        TRIGGER_MECHANICUS_BATTLE_END_ROUND_MORE_THAN = 618,
        TRIGGER_MECHANICUS_BATTLE_END_ROUND = 619,
        TRIGGER_MECHANICUS_BATTLE_FIN_CHALLENGE_MORE_THAN = 620,
        TRIGGER_MECHANICUS_BATTLE_WATCHER_FINISH_COUNT = 621,
        TRIGGER_MECHANICUS_BATTLE_INTERACT_COUNT = 622,
        TRIGGER_MECHANICUS_BATTLE_DIFFICULT_ESCAPE = 623,
        TRIGGER_MECHANICUS_BATTLE_DIFFICULT_GEAR_NUM = 624,
        TRIGGER_MECHANICUS_BATTLE_DIFFICULT_GEAR_ID_NUM = 625,
        TRIGGER_FLEUR_FAIR_DUNGEON_FINISH_IN_LIMIT_TIME = 626,
        TRIGGER_FLEUR_FAIR_DUNGEON_FINISH_KEEP_ENERGY = 627,
        TRIGGER_FLEUR_FAIR_DUNGEON_FINISH_WITH_GROUP_VARIABLE = 628,
        TRIGGER_FLEUR_FAIR_DUNGEON_FINISH_WITH_BUFF_NUM = 629,
        TRIGGER_FLEUR_FAIR_DUNGEON_MISSION_FINISH = 630,
        TRIGGER_FINISH_DUNGEON_AND_CHALLENGE_REMAIN_TIME_GREATER_THAN = 631,
        TRIGGER_FINISH_DUNGEON_WITH_MIST_TRIAL_STAT = 632,
        TRIGGER_DUNGEON_MIST_TRIAL_STAT = 633,
        TRIGGER_DUNGEON_ELEMENT_REACTION_NUM = 634,
        TRIGGER_LEVEL_AVATAR_FINISH_DUNGEON_COUNT = 635,
        TRIGGER_CHESS_REACH_LEVEL = 636,
        TRIGGER_CHESS_DUNGEON_ADD_SCORE = 637,
        TRIGGER_CHESS_DUNGEON_SUCC_WITH_ESCAPED_MONSTERS_LESS_THAN = 638,
        TRIGGER_CHESS_DUNGEON_SUCC_WITH_TOWER_COUNT_LESS_OR_EQUAL = 639,
        TRIGGER_CHESS_DUNGEON_SUCC_WITH_CARD_COUNT_LESS_OR_EQUAL = 640,
        TRIGGER_CHESS_DUNGEON_SUCC_WITH_CARD_COUNT_GREATER_THAN = 641,
        TRIGGER_CHESS_KILL_MONSTERS = 642,
        TRIGGER_CHESS_COST_BUILDING_POINTS = 643,
        TRIGGER_SUMO_STAGE_SCORE_REACH = 644,
        TRIGGER_SUMO_TOTAL_MAX_SCORE_REACH = 645,
        TRIGGER_ROGUE_DESTROY_GADGET_NUM = 646,
        TRIGGER_ROGUE_KILL_MONSTER_NUM = 647,
        TRIGGER_ROGUE_FINISH_WITHOUT_USING_SPRING_CELL = 649,
        TRIGGER_ROGUE_FINISH_ALL_CHALLENGE_CELL = 650,
        TRIGGER_ROGUE_FINISH_WITH_AVATAR_ELEMENT_TYPE_NUM_LESS_THAN = 651,
        TRIGGER_ROGUE_FINISH_WITH_AVATAR_NUM_LESS_THAN = 652,
        TRIGGER_ROGUE_FINISH_NO_AVATAR_DEAD = 653,
        TRIGGER_ROGUE_SHIKIGAMI_UPGRADE = 654,
        TRIGGER_ROGUE_CURSE_NUM = 655,
        TRIGGER_ROGUE_SELECT_CARD_NUM = 656,
        TRIGGER_FINISH_QUEST_AND = 700,
        TRIGGER_FINISH_QUEST_OR = 701,
        TRIGGER_DAILY_TASK_VAR_EQUAL = 702,
        TRIGGER_QUEST_GLOBAL_VAR_EQUAL = 703,
        TRIGGER_TALK_NUM = 704,
        TRIGGER_FINISH_PARENT_QUEST_AND = 705,
        TRIGGER_FINISH_PARENT_QUEST_OR = 706,
        TRIGGER_ELEMENT_REACTION_TIMELIMIT_NUM = 800,
        TRIGGER_ELEMENT_REACTION_TIMELIMIT_KILL_NUM = 801,
        TRIGGER_ELEMENT_REACTION_TIMELIMIT_DAMAGE_NUM = 802,
        TRIGGER_ABILITY_STATE_PASS_TIME = 803,
        TRIGGER_MAX_CRITICAL_DAMAGE = 804,
        TRIGGER_FULL_SATIATION_TEAM_AVATAR_NUM = 805,
        TRIGGER_KILLED_BY_CERTAIN_MONSTER = 806,
        TRIGGER_CUR_AVATAR_HURT = 807,
        TRIGGER_CUR_AVATAR_ABILITY_STATE = 808,
        TRIGGER_USE_ENERGY_SKILL_NUM_TIMELIMIT = 809,
        TRIGGER_SHIELD_SOURCE_NUM = 810,
        TRIGGER_CUR_AVATAR_HURT_BY_SPECIFIC_ABILITY = 811,
        TRIGGER_KILLED_BY_SPECIFIC_ABILITY = 812,
        TRIGGER_MAX_DASH_TIME = 900,
        TRIGGER_MAX_FLY_TIME = 901,
        TRIGGER_MAX_FLY_MAP_DISTANCE = 902,
        TRIGGER_SIT_DOWN_IN_POINT = 903,
        TRIGGER_DASH = 904,
        TRIGGER_CLIMB = 905,
        TRIGGER_FLY = 906,
        TRIGGER_CITY_REPUTATION_LEVEL = 930,
        TRIGGER_CITY_REPUTATION_FINISH_REQUEST = 931,
        TRIGGER_HUNTING_FINISH_NUM = 932,
        TRIGGER_HUNTING_FAIL_NUM = 933,
        TRIGGER_OFFERING_LEVEL = 934,
        TRIGGER_MIRACLE_RING_DELIVER_ITEM = 935,
        TRIGGER_MIRACLE_RING_TAKE_REWARD = 936,
        TRIGGER_BLESSING_EXCHANGE_PIC_NUM = 937,
        TRIGGER_BLESSING_REDEEM_REWARD_NUM = 938,
        TRIGGER_GALLERY_BALLOON_REACH_SCORE = 939,
        TRIGGER_GALLERY_FALL_REACH_SCORE = 940,
        TRIGGER_FLEUR_FAIR_MUSIC_GAME_REACH_SCORE = 941,
        TRIGGER_MAIN_COOP_SAVE_POINT_AND = 942,
        TRIGGER_MAIN_COOP_SAVE_POINT_OR = 943,
        TRIGGER_MAIN_COOP_VAR_EQUAL = 944,
        TRIGGER_FINISH_ALL_ARENA_CHALLENGE_WATCHER_IN_SCHEDULE = 945,
        TRIGGER_GALLERY_BUOYANT_COMBAT_REACH_SCORE = 946,
        TRIGGER_BUOYANT_COMBAT_REACH_NEW_SCORE_LEVEL = 947,
        TRIGGER_PLACE_MIRACLE_RING = 948,
        TRIGGER_LUNA_RITE_SEARCH = 949,
        TRIGGER_GALLERY_FISH_REACH_SCORE = 950,
        TRIGGER_GALLERY_TRIATHLON_REACH_SCORE = 951,
        TRIGGER_WINTER_CAMP_SNOWMAN_COMPLEIET = 952,
        TRIGGER_CREATE_CUSTOM_DUNGEON = 953,
        TRIGGER_PUBLISH_CUSTOM_DUNGEON = 954,
        TRIGGER_PLAY_OTHER_CUSTOM_DUNGEON = 955,
        TRIGGER_FINISH_CUSTOM_DUNGEON_OFFICIAL = 956,
        TRIGGER_CUSTOM_DUNGEON_OFFICIAL_COIN = 957,
        TRIGGER_OBTAIN_WOOD_TYPE = 1000,
        TRIGGER_OBTAIN_WOOD_COUNT = 1001,
        TRIGGER_UNLOCK_FURNITURE_COUNT = 1002,
        TRIGGER_FURNITURE_MAKE = 1003,
        TRIGGER_HOME_LEVEL = 1004,
        TRIGGER_HOME_COIN = 1005,
        TRIGGER_HOME_COMFORT_LEVEL = 1006,
        TRIGGER_HOME_LIMITED_SHOP_BUY = 1007,
        TRIGGER_FURNITURE_SUITE_TYPE = 1008,
        TRIGGER_ARRANGEMENT_FURNITURE_COUNT = 1009,
        TRIGGER_ENTER_SELF_HOME = 1010,
        TRIGGER_HOME_MODULE_COMFORT_VALUE = 1011,
        TRIGGER_HOME_ENTER_ROOM = 1012,
        TRIGGER_HOME_AVATAR_IN = 1013,
        TRIGGER_HOME_AVATAR_REWARD_EVENT_COUNT = 1014,
        TRIGGER_HOME_AVATAR_TALK_FINISH_COUNT = 1015,
        TRIGGER_HOME_AVATAR_REWARD_EVENT_ALL_COUNT = 1016,
        TRIGGER_HOME_AVATAR_TALK_FINISH_ALL_COUNT = 1017,
        TRIGGER_HOME_AVATAR_FETTER_GET = 1018,
        TRIGGER_HOME_AVATAR_IN_COUNT = 1019,
        TRIGGER_HOME_DO_PLANT = 1020,
        TRIGGER_ARRANGEMENT_FURNITURE = 1021,
        TRIGGER_HOME_GATHER_COUNT = 1022,
        TRIGGER_HOME_FIELD_GATHER_COUNT = 1023,
        TRIGGER_HOME_UNLOCK_BGM_COUNT = 1024,
        TRIGGER_FISHING_SUCC_NUM = 1100,
        TRIGGER_FISHING_KEEP_BONUS = 1101,
        TRIGGER_EMPTY_FISH_POOL = 1102,
        TRIGGER_FISHING_FAIL_NUM = 1103,
        TRIGGER_SHOCK_FISH_NUM = 1104,
        TRIGGER_PLANT_FLOWER_SET_WISH = 1105,
        TRIGGER_PLANT_FLOWER_GIVE_FLOWER = 1106,
        TRIGGER_PLANT_FLOWER_OBTAIN_FLOWER_TYPE = 1107,
        TRIGGER_PLANT_FLOWER_COMMON_OBTAIN_FLOWER_TYPE = 1108,
        TRIGGER_FINISH_LANV2_PROJECTION_LEVEL = 1111,
        TRIGGER_GALLERY_SALVAGE_REACH_SCORE = 1112,
        TRIGGER_LANV2_FIREWORKS_CHALLENGE_REACH_SCORE = 1113,
        TRIGGER_POTION_STAGE_LEVEL_PASS_NUM = 1115,
        TRIGGER_POTION_STAGE_OBTAIN_MEDAL_NUM = 1116,
        TRIGGER_POTION_STAGE_REACH_TOTAL_SCORE = 1117,
        TRIGGER_BARTENDER_FINISH_STORY_MODULE = 1120,
        TRIGGER_BARTENDER_CHALLENGE_MODULE_LEVEL_SCORE = 1121,
        TRIGGER_BARTENDER_UNLOCK_FORMULA = 1122,
        TRIGGER_MICHIAE_MATSURI_UNLOCK_CRYSTAL_SKILL_REACH_NUM = 1123,
        TRIGGER_MICHIAE_MATSURI_FINISH_DARK_CHALLENGE_REACH_NUM = 1124,
        TRIGGER_CAPTURE_ENV_ANIMAL_REACH_NUM = 1125,
        TRIGGER_SPICE_MAKE_FORMULA_TIMES = 1126,
        TRIGGER_SPICE_GIVE_FOOD_TIMES = 1127,
        TRIGGER_SPICE_MAKE_FORMULA_SUCCESSFUL_TIMES = 1128,
        TRIGGER_IRODORI_FINISH_FLOWER_THEME = 1131,
        TRIGGER_IRODORI_FINISH_MASTER_STAGE = 1132,
        TRIGGER_IRODORI_CHESS_STAGE_REACH_SCORE = 1133,
        TRIGGER_IRODORI_FINISH_POETRY_THEME = 1134,
        TRIGGER_PHOTO_FINISH_POS_ID = 1135,
        TRIGGER_CRYSTAL_LINK_LEVEL_SCORE_REACH = 1138,
        TRIGGER_CRYSTAL_LINK_TOTAL_MAX_SCORE_REACH = 1139
    }
}
