namespace TPLibraryProject;

public enum SightsOfSydney
{
    Sydney,
    Auburn,
    Chatswood,
    Blacktown,
    Rhodes,
    TownHall,
    Bondi,
    DulwichHill
}

public enum SightsOfSydneyList : byte
{
    Sydney      = 0b_0000_0001,
    Auburn      = 0b_0000_0010,
    Chatswood   = 0b_0000_0100,
    Blacktown   = 0b_0000_1000,
    Rhodes      = 0b_0000_1000,
    TownHall    = 0b_0001_0000,
    Bondi       = 0b_0010_0000,
    DulwichHill = 0b_1000_0000
}
