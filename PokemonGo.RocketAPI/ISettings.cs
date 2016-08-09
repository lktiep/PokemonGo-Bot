using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using PokemonGo.RocketAPI.Enums;
using System.Collections.Generic;

namespace PokemonGo.RocketAPI
{
    public interface ISettings
    {
        AuthType AuthType { get; }
        double DefaultLatitude { get; }
        double DefaultLongitude { get; }
        double DefaultAltitude { get; }
        string GoogleRefreshToken { get; set; }
        string PtcPassword { get; }
        string PtcUsername { get; }
        string GoogleUsername { get; }
        string GooglePassword { get; }

        bool UseLastCords { get; }

        bool WalkBackToDefaultLocation { get; }
        int MaxWalkingRadiusInMeters { get; }
        int HoldMaxDoublePokemons { get; }

        int TelegramLiveStatsDelay { get; }

        double WalkingSpeedInKilometerPerHour { get; }

        bool EvolvePokemonsIfEnoughCandy { get; }
        bool TransferDoublePokemons { get; }

        int DontTransferWithCPOver { get; }
        int TransferWithCPUnder { get; }
        int ivmaxpercent { get; }
        int ivminpercent { get; }
        string Priority { get; }

        string TelegramAPIToken { get; }
        string TelegramName { get; }

        int navigation_option { get; }

        bool UseLuckyEgg { get; }
        bool UseLuckyEggIfNotRunning { get; }
        bool keepPokemonsThatCanEvolve { get; }
        bool UseIncense { get; }

        bool AutoIncubate { get; }
        bool UseBasicIncubators { get; } 

        bool pokevision { get; }

        bool Language { get; }

        ICollection<KeyValuePair<ItemId, int>> itemRecycleFilter { get; set; }

        List<PokemonId> pokemonsToHold { get; set; }
        List<PokemonId> pokemonsToEvolve { get; set; }
        List<PokemonId> catchPokemonSkipList { get; }


    }
}