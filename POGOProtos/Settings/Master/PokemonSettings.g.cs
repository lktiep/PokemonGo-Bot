// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/PokemonSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/PokemonSettings.proto</summary>
  public static partial class PokemonSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/PokemonSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uU2V0dGluZ3Mu",
            "cHJvdG8SGlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyGiBQT0dPUHJvdG9z",
            "L0VudW1zL1Bva2Vtb25JZC5wcm90bxokUE9HT1Byb3Rvcy9FbnVtcy9Qb2tl",
            "bW9uUmFyaXR5LnByb3RvGiJQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25UeXBl",
            "LnByb3RvGiJQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25Nb3ZlLnByb3RvGiZQ",
            "T0dPUHJvdG9zL0VudW1zL1Bva2Vtb25GYW1pbHlJZC5wcm90bxo4UE9HT1By",
            "b3Rvcy9TZXR0aW5ncy9NYXN0ZXIvUG9rZW1vbi9TdGF0c0F0dHJpYnV0ZXMu",
            "cHJvdG8aOVBPR09Qcm90b3MvU2V0dGluZ3MvTWFzdGVyL1Bva2Vtb24vQ2Ft",
            "ZXJhQXR0cmlidXRlcy5wcm90bxo8UE9HT1Byb3Rvcy9TZXR0aW5ncy9NYXN0",
            "ZXIvUG9rZW1vbi9FbmNvdW50ZXJBdHRyaWJ1dGVzLnByb3RvGjhQT0dPUHJv",
            "dG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uL0V2b2x1dGlvbkJyYW5jaC5w",
            "cm90byLDCQoPUG9rZW1vblNldHRpbmdzEi8KCnBva2Vtb25faWQYASABKA4y",
            "Gy5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25JZBITCgttb2RlbF9zY2FsZRgD",
            "IAEoAhIrCgR0eXBlGAQgASgOMh0uUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9u",
            "VHlwZRItCgZ0eXBlXzIYBSABKA4yHS5QT0dPUHJvdG9zLkVudW1zLlBva2Vt",
            "b25UeXBlEkQKBmNhbWVyYRgGIAEoCzI0LlBPR09Qcm90b3MuU2V0dGluZ3Mu",
            "TWFzdGVyLlBva2Vtb24uQ2FtZXJhQXR0cmlidXRlcxJKCgllbmNvdW50ZXIY",
            "ByABKAsyNy5QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5Qb2tlbW9uLkVu",
            "Y291bnRlckF0dHJpYnV0ZXMSQgoFc3RhdHMYCCABKAsyMy5QT0dPUHJvdG9z",
            "LlNldHRpbmdzLk1hc3Rlci5Qb2tlbW9uLlN0YXRzQXR0cmlidXRlcxIyCgtx",
            "dWlja19tb3ZlcxgJIAMoDjIdLlBPR09Qcm90b3MuRW51bXMuUG9rZW1vbk1v",
            "dmUSNgoPY2luZW1hdGljX21vdmVzGAogAygOMh0uUE9HT1Byb3Rvcy5FbnVt",
            "cy5Qb2tlbW9uTW92ZRIWCg5hbmltYXRpb25fdGltZRgLIAMoAhIyCg1ldm9s",
            "dXRpb25faWRzGAwgAygOMhsuUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9uSWQS",
            "FgoOZXZvbHV0aW9uX3BpcHMYDSABKAUSLwoGcmFyaXR5GA4gASgOMh8uUE9H",
            "T1Byb3Rvcy5FbnVtcy5Qb2tlbW9uUmFyaXR5EhgKEHBva2VkZXhfaGVpZ2h0",
            "X20YDyABKAISGQoRcG9rZWRleF93ZWlnaHRfa2cYECABKAISNgoRcGFyZW50",
            "X3Bva2Vtb25faWQYESABKA4yGy5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25J",
            "ZBIWCg5oZWlnaHRfc3RkX2RldhgSIAEoAhIWCg53ZWlnaHRfc3RkX2RldhgT",
            "IAEoAhIcChRrbV9kaXN0YW5jZV90b19oYXRjaBgUIAEoAhI0CglmYW1pbHlf",
            "aWQYFSABKA4yIS5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25GYW1pbHlJZBIX",
            "Cg9jYW5keV90b19ldm9sdmUYFiABKAUSGQoRa21fYnVkZHlfZGlzdGFuY2UY",
            "FyABKAISSQoKYnVkZHlfc2l6ZRgYIAEoDjI1LlBPR09Qcm90b3MuU2V0dGlu",
            "Z3MuTWFzdGVyLlBva2Vtb25TZXR0aW5ncy5CdWRkeVNpemUSFAoMbW9kZWxf",
            "aGVpZ2h0GBkgASgCEk0KEGV2b2x1dGlvbl9icmFuY2gYGiADKAsyMy5QT0dP",
            "UHJvdG9zLlNldHRpbmdzLk1hc3Rlci5Qb2tlbW9uLkV2b2x1dGlvbkJyYW5j",
            "aCJiCglCdWRkeVNpemUSEAoMQlVERFlfTUVESVVNEAASEgoOQlVERFlfU0hP",
            "VUxERVIQARINCglCVUREWV9CSUcQAhIQCgxCVUREWV9GTFlJTkcQAxIOCgpC",
            "VUREWV9CQUJZEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, global::POGOProtos.Enums.PokemonRarityReflection.Descriptor, global::POGOProtos.Enums.PokemonTypeReflection.Descriptor, global::POGOProtos.Enums.PokemonMoveReflection.Descriptor, global::POGOProtos.Enums.PokemonFamilyIdReflection.Descriptor, global::POGOProtos.Settings.Master.Pokemon.StatsAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Pokemon.CameraAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Pokemon.EncounterAttributesReflection.Descriptor, global::POGOProtos.Settings.Master.Pokemon.EvolutionBranchReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.PokemonSettings), global::POGOProtos.Settings.Master.PokemonSettings.Parser, new[]{ "PokemonId", "ModelScale", "Type", "Type2", "Camera", "Encounter", "Stats", "QuickMoves", "CinematicMoves", "AnimationTime", "EvolutionIds", "EvolutionPips", "Rarity", "PokedexHeightM", "PokedexWeightKg", "ParentPokemonId", "HeightStdDev", "WeightStdDev", "KmDistanceToHatch", "FamilyId", "CandyToEvolve", "KmBuddyDistance", "BuddySize", "ModelHeight", "EvolutionBranch" }, null, new[]{ typeof(global::POGOProtos.Settings.Master.PokemonSettings.Types.BuddySize) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PokemonSettings : pb::IMessage<PokemonSettings> {
    private static readonly pb::MessageParser<PokemonSettings> _parser = new pb::MessageParser<PokemonSettings>(() => new PokemonSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PokemonSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.PokemonSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonSettings(PokemonSettings other) : this() {
      pokemonId_ = other.pokemonId_;
      modelScale_ = other.modelScale_;
      type_ = other.type_;
      type2_ = other.type2_;
      Camera = other.camera_ != null ? other.Camera.Clone() : null;
      Encounter = other.encounter_ != null ? other.Encounter.Clone() : null;
      Stats = other.stats_ != null ? other.Stats.Clone() : null;
      quickMoves_ = other.quickMoves_.Clone();
      cinematicMoves_ = other.cinematicMoves_.Clone();
      animationTime_ = other.animationTime_.Clone();
      evolutionIds_ = other.evolutionIds_.Clone();
      evolutionPips_ = other.evolutionPips_;
      rarity_ = other.rarity_;
      pokedexHeightM_ = other.pokedexHeightM_;
      pokedexWeightKg_ = other.pokedexWeightKg_;
      parentPokemonId_ = other.parentPokemonId_;
      heightStdDev_ = other.heightStdDev_;
      weightStdDev_ = other.weightStdDev_;
      kmDistanceToHatch_ = other.kmDistanceToHatch_;
      familyId_ = other.familyId_;
      candyToEvolve_ = other.candyToEvolve_;
      kmBuddyDistance_ = other.kmBuddyDistance_;
      buddySize_ = other.buddySize_;
      modelHeight_ = other.modelHeight_;
      evolutionBranch_ = other.evolutionBranch_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonSettings Clone() {
      return new PokemonSettings(this);
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 1;
    private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "model_scale" field.</summary>
    public const int ModelScaleFieldNumber = 3;
    private float modelScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ModelScale {
      get { return modelScale_; }
      set {
        modelScale_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::POGOProtos.Enums.PokemonType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "type_2" field.</summary>
    public const int Type2FieldNumber = 5;
    private global::POGOProtos.Enums.PokemonType type2_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonType Type2 {
      get { return type2_; }
      set {
        type2_ = value;
      }
    }

    /// <summary>Field number for the "camera" field.</summary>
    public const int CameraFieldNumber = 6;
    private global::POGOProtos.Settings.Master.Pokemon.CameraAttributes camera_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Pokemon.CameraAttributes Camera {
      get { return camera_; }
      set {
        camera_ = value;
      }
    }

    /// <summary>Field number for the "encounter" field.</summary>
    public const int EncounterFieldNumber = 7;
    private global::POGOProtos.Settings.Master.Pokemon.EncounterAttributes encounter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Pokemon.EncounterAttributes Encounter {
      get { return encounter_; }
      set {
        encounter_ = value;
      }
    }

    /// <summary>Field number for the "stats" field.</summary>
    public const int StatsFieldNumber = 8;
    private global::POGOProtos.Settings.Master.Pokemon.StatsAttributes stats_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.Pokemon.StatsAttributes Stats {
      get { return stats_; }
      set {
        stats_ = value;
      }
    }

    /// <summary>Field number for the "quick_moves" field.</summary>
    public const int QuickMovesFieldNumber = 9;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.PokemonMove> _repeated_quickMoves_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::POGOProtos.Enums.PokemonMove) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.PokemonMove> quickMoves_ = new pbc::RepeatedField<global::POGOProtos.Enums.PokemonMove>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.PokemonMove> QuickMoves {
      get { return quickMoves_; }
    }

    /// <summary>Field number for the "cinematic_moves" field.</summary>
    public const int CinematicMovesFieldNumber = 10;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.PokemonMove> _repeated_cinematicMoves_codec
        = pb::FieldCodec.ForEnum(82, x => (int) x, x => (global::POGOProtos.Enums.PokemonMove) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.PokemonMove> cinematicMoves_ = new pbc::RepeatedField<global::POGOProtos.Enums.PokemonMove>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.PokemonMove> CinematicMoves {
      get { return cinematicMoves_; }
    }

    /// <summary>Field number for the "animation_time" field.</summary>
    public const int AnimationTimeFieldNumber = 11;
    private static readonly pb::FieldCodec<float> _repeated_animationTime_codec
        = pb::FieldCodec.ForFloat(90);
    private readonly pbc::RepeatedField<float> animationTime_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> AnimationTime {
      get { return animationTime_; }
    }

    /// <summary>Field number for the "evolution_ids" field.</summary>
    public const int EvolutionIdsFieldNumber = 12;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.PokemonId> _repeated_evolutionIds_codec
        = pb::FieldCodec.ForEnum(98, x => (int) x, x => (global::POGOProtos.Enums.PokemonId) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.PokemonId> evolutionIds_ = new pbc::RepeatedField<global::POGOProtos.Enums.PokemonId>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.PokemonId> EvolutionIds {
      get { return evolutionIds_; }
    }

    /// <summary>Field number for the "evolution_pips" field.</summary>
    public const int EvolutionPipsFieldNumber = 13;
    private int evolutionPips_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EvolutionPips {
      get { return evolutionPips_; }
      set {
        evolutionPips_ = value;
      }
    }

    /// <summary>Field number for the "rarity" field.</summary>
    public const int RarityFieldNumber = 14;
    private global::POGOProtos.Enums.PokemonRarity rarity_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonRarity Rarity {
      get { return rarity_; }
      set {
        rarity_ = value;
      }
    }

    /// <summary>Field number for the "pokedex_height_m" field.</summary>
    public const int PokedexHeightMFieldNumber = 15;
    private float pokedexHeightM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PokedexHeightM {
      get { return pokedexHeightM_; }
      set {
        pokedexHeightM_ = value;
      }
    }

    /// <summary>Field number for the "pokedex_weight_kg" field.</summary>
    public const int PokedexWeightKgFieldNumber = 16;
    private float pokedexWeightKg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PokedexWeightKg {
      get { return pokedexWeightKg_; }
      set {
        pokedexWeightKg_ = value;
      }
    }

    /// <summary>Field number for the "parent_pokemon_id" field.</summary>
    public const int ParentPokemonIdFieldNumber = 17;
    private global::POGOProtos.Enums.PokemonId parentPokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId ParentPokemonId {
      get { return parentPokemonId_; }
      set {
        parentPokemonId_ = value;
      }
    }

    /// <summary>Field number for the "height_std_dev" field.</summary>
    public const int HeightStdDevFieldNumber = 18;
    private float heightStdDev_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float HeightStdDev {
      get { return heightStdDev_; }
      set {
        heightStdDev_ = value;
      }
    }

    /// <summary>Field number for the "weight_std_dev" field.</summary>
    public const int WeightStdDevFieldNumber = 19;
    private float weightStdDev_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float WeightStdDev {
      get { return weightStdDev_; }
      set {
        weightStdDev_ = value;
      }
    }

    /// <summary>Field number for the "km_distance_to_hatch" field.</summary>
    public const int KmDistanceToHatchFieldNumber = 20;
    private float kmDistanceToHatch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float KmDistanceToHatch {
      get { return kmDistanceToHatch_; }
      set {
        kmDistanceToHatch_ = value;
      }
    }

    /// <summary>Field number for the "family_id" field.</summary>
    public const int FamilyIdFieldNumber = 21;
    private global::POGOProtos.Enums.PokemonFamilyId familyId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonFamilyId FamilyId {
      get { return familyId_; }
      set {
        familyId_ = value;
      }
    }

    /// <summary>Field number for the "candy_to_evolve" field.</summary>
    public const int CandyToEvolveFieldNumber = 22;
    private int candyToEvolve_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CandyToEvolve {
      get { return candyToEvolve_; }
      set {
        candyToEvolve_ = value;
      }
    }

    /// <summary>Field number for the "km_buddy_distance" field.</summary>
    public const int KmBuddyDistanceFieldNumber = 23;
    private float kmBuddyDistance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float KmBuddyDistance {
      get { return kmBuddyDistance_; }
      set {
        kmBuddyDistance_ = value;
      }
    }

    /// <summary>Field number for the "buddy_size" field.</summary>
    public const int BuddySizeFieldNumber = 24;
    private global::POGOProtos.Settings.Master.PokemonSettings.Types.BuddySize buddySize_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.PokemonSettings.Types.BuddySize BuddySize {
      get { return buddySize_; }
      set {
        buddySize_ = value;
      }
    }

    /// <summary>Field number for the "model_height" field.</summary>
    public const int ModelHeightFieldNumber = 25;
    private float modelHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ModelHeight {
      get { return modelHeight_; }
      set {
        modelHeight_ = value;
      }
    }

    /// <summary>Field number for the "evolution_branch" field.</summary>
    public const int EvolutionBranchFieldNumber = 26;
    private static readonly pb::FieldCodec<global::POGOProtos.Settings.Master.Pokemon.EvolutionBranch> _repeated_evolutionBranch_codec
        = pb::FieldCodec.ForMessage(210, global::POGOProtos.Settings.Master.Pokemon.EvolutionBranch.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Settings.Master.Pokemon.EvolutionBranch> evolutionBranch_ = new pbc::RepeatedField<global::POGOProtos.Settings.Master.Pokemon.EvolutionBranch>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Settings.Master.Pokemon.EvolutionBranch> EvolutionBranch {
      get { return evolutionBranch_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PokemonSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PokemonSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonId != other.PokemonId) return false;
      if (ModelScale != other.ModelScale) return false;
      if (Type != other.Type) return false;
      if (Type2 != other.Type2) return false;
      if (!object.Equals(Camera, other.Camera)) return false;
      if (!object.Equals(Encounter, other.Encounter)) return false;
      if (!object.Equals(Stats, other.Stats)) return false;
      if(!quickMoves_.Equals(other.quickMoves_)) return false;
      if(!cinematicMoves_.Equals(other.cinematicMoves_)) return false;
      if(!animationTime_.Equals(other.animationTime_)) return false;
      if(!evolutionIds_.Equals(other.evolutionIds_)) return false;
      if (EvolutionPips != other.EvolutionPips) return false;
      if (Rarity != other.Rarity) return false;
      if (PokedexHeightM != other.PokedexHeightM) return false;
      if (PokedexWeightKg != other.PokedexWeightKg) return false;
      if (ParentPokemonId != other.ParentPokemonId) return false;
      if (HeightStdDev != other.HeightStdDev) return false;
      if (WeightStdDev != other.WeightStdDev) return false;
      if (KmDistanceToHatch != other.KmDistanceToHatch) return false;
      if (FamilyId != other.FamilyId) return false;
      if (CandyToEvolve != other.CandyToEvolve) return false;
      if (KmBuddyDistance != other.KmBuddyDistance) return false;
      if (BuddySize != other.BuddySize) return false;
      if (ModelHeight != other.ModelHeight) return false;
      if(!evolutionBranch_.Equals(other.evolutionBranch_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      if (ModelScale != 0F) hash ^= ModelScale.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Type2 != 0) hash ^= Type2.GetHashCode();
      if (camera_ != null) hash ^= Camera.GetHashCode();
      if (encounter_ != null) hash ^= Encounter.GetHashCode();
      if (stats_ != null) hash ^= Stats.GetHashCode();
      hash ^= quickMoves_.GetHashCode();
      hash ^= cinematicMoves_.GetHashCode();
      hash ^= animationTime_.GetHashCode();
      hash ^= evolutionIds_.GetHashCode();
      if (EvolutionPips != 0) hash ^= EvolutionPips.GetHashCode();
      if (Rarity != 0) hash ^= Rarity.GetHashCode();
      if (PokedexHeightM != 0F) hash ^= PokedexHeightM.GetHashCode();
      if (PokedexWeightKg != 0F) hash ^= PokedexWeightKg.GetHashCode();
      if (ParentPokemonId != 0) hash ^= ParentPokemonId.GetHashCode();
      if (HeightStdDev != 0F) hash ^= HeightStdDev.GetHashCode();
      if (WeightStdDev != 0F) hash ^= WeightStdDev.GetHashCode();
      if (KmDistanceToHatch != 0F) hash ^= KmDistanceToHatch.GetHashCode();
      if (FamilyId != 0) hash ^= FamilyId.GetHashCode();
      if (CandyToEvolve != 0) hash ^= CandyToEvolve.GetHashCode();
      if (KmBuddyDistance != 0F) hash ^= KmBuddyDistance.GetHashCode();
      if (BuddySize != 0) hash ^= BuddySize.GetHashCode();
      if (ModelHeight != 0F) hash ^= ModelHeight.GetHashCode();
      hash ^= evolutionBranch_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PokemonId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) PokemonId);
      }
      if (ModelScale != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(ModelScale);
      }
      if (Type != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Type2 != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Type2);
      }
      if (camera_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Camera);
      }
      if (encounter_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Encounter);
      }
      if (stats_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Stats);
      }
      quickMoves_.WriteTo(output, _repeated_quickMoves_codec);
      cinematicMoves_.WriteTo(output, _repeated_cinematicMoves_codec);
      animationTime_.WriteTo(output, _repeated_animationTime_codec);
      evolutionIds_.WriteTo(output, _repeated_evolutionIds_codec);
      if (EvolutionPips != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(EvolutionPips);
      }
      if (Rarity != 0) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Rarity);
      }
      if (PokedexHeightM != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(PokedexHeightM);
      }
      if (PokedexWeightKg != 0F) {
        output.WriteRawTag(133, 1);
        output.WriteFloat(PokedexWeightKg);
      }
      if (ParentPokemonId != 0) {
        output.WriteRawTag(136, 1);
        output.WriteEnum((int) ParentPokemonId);
      }
      if (HeightStdDev != 0F) {
        output.WriteRawTag(149, 1);
        output.WriteFloat(HeightStdDev);
      }
      if (WeightStdDev != 0F) {
        output.WriteRawTag(157, 1);
        output.WriteFloat(WeightStdDev);
      }
      if (KmDistanceToHatch != 0F) {
        output.WriteRawTag(165, 1);
        output.WriteFloat(KmDistanceToHatch);
      }
      if (FamilyId != 0) {
        output.WriteRawTag(168, 1);
        output.WriteEnum((int) FamilyId);
      }
      if (CandyToEvolve != 0) {
        output.WriteRawTag(176, 1);
        output.WriteInt32(CandyToEvolve);
      }
      if (KmBuddyDistance != 0F) {
        output.WriteRawTag(189, 1);
        output.WriteFloat(KmBuddyDistance);
      }
      if (BuddySize != 0) {
        output.WriteRawTag(192, 1);
        output.WriteEnum((int) BuddySize);
      }
      if (ModelHeight != 0F) {
        output.WriteRawTag(205, 1);
        output.WriteFloat(ModelHeight);
      }
      evolutionBranch_.WriteTo(output, _repeated_evolutionBranch_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      if (ModelScale != 0F) {
        size += 1 + 4;
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Type2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type2);
      }
      if (camera_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Camera);
      }
      if (encounter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Encounter);
      }
      if (stats_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stats);
      }
      size += quickMoves_.CalculateSize(_repeated_quickMoves_codec);
      size += cinematicMoves_.CalculateSize(_repeated_cinematicMoves_codec);
      size += animationTime_.CalculateSize(_repeated_animationTime_codec);
      size += evolutionIds_.CalculateSize(_repeated_evolutionIds_codec);
      if (EvolutionPips != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionPips);
      }
      if (Rarity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Rarity);
      }
      if (PokedexHeightM != 0F) {
        size += 1 + 4;
      }
      if (PokedexWeightKg != 0F) {
        size += 2 + 4;
      }
      if (ParentPokemonId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) ParentPokemonId);
      }
      if (HeightStdDev != 0F) {
        size += 2 + 4;
      }
      if (WeightStdDev != 0F) {
        size += 2 + 4;
      }
      if (KmDistanceToHatch != 0F) {
        size += 2 + 4;
      }
      if (FamilyId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) FamilyId);
      }
      if (CandyToEvolve != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(CandyToEvolve);
      }
      if (KmBuddyDistance != 0F) {
        size += 2 + 4;
      }
      if (BuddySize != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) BuddySize);
      }
      if (ModelHeight != 0F) {
        size += 2 + 4;
      }
      size += evolutionBranch_.CalculateSize(_repeated_evolutionBranch_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PokemonSettings other) {
      if (other == null) {
        return;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
      if (other.ModelScale != 0F) {
        ModelScale = other.ModelScale;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Type2 != 0) {
        Type2 = other.Type2;
      }
      if (other.camera_ != null) {
        if (camera_ == null) {
          camera_ = new global::POGOProtos.Settings.Master.Pokemon.CameraAttributes();
        }
        Camera.MergeFrom(other.Camera);
      }
      if (other.encounter_ != null) {
        if (encounter_ == null) {
          encounter_ = new global::POGOProtos.Settings.Master.Pokemon.EncounterAttributes();
        }
        Encounter.MergeFrom(other.Encounter);
      }
      if (other.stats_ != null) {
        if (stats_ == null) {
          stats_ = new global::POGOProtos.Settings.Master.Pokemon.StatsAttributes();
        }
        Stats.MergeFrom(other.Stats);
      }
      quickMoves_.Add(other.quickMoves_);
      cinematicMoves_.Add(other.cinematicMoves_);
      animationTime_.Add(other.animationTime_);
      evolutionIds_.Add(other.evolutionIds_);
      if (other.EvolutionPips != 0) {
        EvolutionPips = other.EvolutionPips;
      }
      if (other.Rarity != 0) {
        Rarity = other.Rarity;
      }
      if (other.PokedexHeightM != 0F) {
        PokedexHeightM = other.PokedexHeightM;
      }
      if (other.PokedexWeightKg != 0F) {
        PokedexWeightKg = other.PokedexWeightKg;
      }
      if (other.ParentPokemonId != 0) {
        ParentPokemonId = other.ParentPokemonId;
      }
      if (other.HeightStdDev != 0F) {
        HeightStdDev = other.HeightStdDev;
      }
      if (other.WeightStdDev != 0F) {
        WeightStdDev = other.WeightStdDev;
      }
      if (other.KmDistanceToHatch != 0F) {
        KmDistanceToHatch = other.KmDistanceToHatch;
      }
      if (other.FamilyId != 0) {
        FamilyId = other.FamilyId;
      }
      if (other.CandyToEvolve != 0) {
        CandyToEvolve = other.CandyToEvolve;
      }
      if (other.KmBuddyDistance != 0F) {
        KmBuddyDistance = other.KmBuddyDistance;
      }
      if (other.BuddySize != 0) {
        BuddySize = other.BuddySize;
      }
      if (other.ModelHeight != 0F) {
        ModelHeight = other.ModelHeight;
      }
      evolutionBranch_.Add(other.evolutionBranch_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 29: {
            ModelScale = input.ReadFloat();
            break;
          }
          case 32: {
            type_ = (global::POGOProtos.Enums.PokemonType) input.ReadEnum();
            break;
          }
          case 40: {
            type2_ = (global::POGOProtos.Enums.PokemonType) input.ReadEnum();
            break;
          }
          case 50: {
            if (camera_ == null) {
              camera_ = new global::POGOProtos.Settings.Master.Pokemon.CameraAttributes();
            }
            input.ReadMessage(camera_);
            break;
          }
          case 58: {
            if (encounter_ == null) {
              encounter_ = new global::POGOProtos.Settings.Master.Pokemon.EncounterAttributes();
            }
            input.ReadMessage(encounter_);
            break;
          }
          case 66: {
            if (stats_ == null) {
              stats_ = new global::POGOProtos.Settings.Master.Pokemon.StatsAttributes();
            }
            input.ReadMessage(stats_);
            break;
          }
          case 74:
          case 72: {
            quickMoves_.AddEntriesFrom(input, _repeated_quickMoves_codec);
            break;
          }
          case 82:
          case 80: {
            cinematicMoves_.AddEntriesFrom(input, _repeated_cinematicMoves_codec);
            break;
          }
          case 90:
          case 93: {
            animationTime_.AddEntriesFrom(input, _repeated_animationTime_codec);
            break;
          }
          case 98:
          case 96: {
            evolutionIds_.AddEntriesFrom(input, _repeated_evolutionIds_codec);
            break;
          }
          case 104: {
            EvolutionPips = input.ReadInt32();
            break;
          }
          case 112: {
            rarity_ = (global::POGOProtos.Enums.PokemonRarity) input.ReadEnum();
            break;
          }
          case 125: {
            PokedexHeightM = input.ReadFloat();
            break;
          }
          case 133: {
            PokedexWeightKg = input.ReadFloat();
            break;
          }
          case 136: {
            parentPokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 149: {
            HeightStdDev = input.ReadFloat();
            break;
          }
          case 157: {
            WeightStdDev = input.ReadFloat();
            break;
          }
          case 165: {
            KmDistanceToHatch = input.ReadFloat();
            break;
          }
          case 168: {
            familyId_ = (global::POGOProtos.Enums.PokemonFamilyId) input.ReadEnum();
            break;
          }
          case 176: {
            CandyToEvolve = input.ReadInt32();
            break;
          }
          case 189: {
            KmBuddyDistance = input.ReadFloat();
            break;
          }
          case 192: {
            buddySize_ = (global::POGOProtos.Settings.Master.PokemonSettings.Types.BuddySize) input.ReadEnum();
            break;
          }
          case 205: {
            ModelHeight = input.ReadFloat();
            break;
          }
          case 210: {
            evolutionBranch_.AddEntriesFrom(input, _repeated_evolutionBranch_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the PokemonSettings message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum BuddySize {
        [pbr::OriginalName("BUDDY_MEDIUM")] BuddyMedium = 0,
        [pbr::OriginalName("BUDDY_SHOULDER")] BuddyShoulder = 1,
        [pbr::OriginalName("BUDDY_BIG")] BuddyBig = 2,
        [pbr::OriginalName("BUDDY_FLYING")] BuddyFlying = 3,
        [pbr::OriginalName("BUDDY_BABY")] BuddyBaby = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
