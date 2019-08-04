﻿namespace Imgeneus.Network.Packets
{
    public enum PacketType : ushort
    {
        // Internal Server
        AUTH_SERVER = 5,
        SERVER_INFO = 6,
        UPDATE_SERVER = 7,
        DISSCONNECT_USER = 8,

        // Character
        CHARACTER_LIST = 0x0101,
        CREATE_CHARACTER = 0x0102,
        DELETE_CHARACTER = 0x0103,
        SELECT_CHARACTER = 0x0104,
        CHARACTER_DETAILS = 0x0105,
        CHARACTER_INVENTORY = 0x0106,
        // Common
        CLOSE_CONNECTION = 0x0107,
        CHARACTER_SKILLS = 0x0108,
        ACCOUNT_FACTION = 0x0109,
        CHARACTER_ACTIVE_SKILL = 0x010A,
        CHARACTER_SKILL_BAR = 0x010B,
        RENAME_CHARACTER = 0x010E,
        RESTORE_CHARACTER = 0x010F,

        // Login Server
        LOGIN_HANDSHAKE = 0xA101,
        LOGIN_REQUEST = 0xA102,
        SERVER_LIST = 0xA201,
        SELECT_SERVER = 0xA202,

        // Game 
        GAME_HANDSHAKE = 0xA301,
    }
}