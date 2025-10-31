// SPDX-FileCopyrightText: 2022 CommieFlowers
// SPDX-FileCopyrightText: 2022 Morb
// SPDX-FileCopyrightText: 2022 Pieter-Jan Briers
// SPDX-FileCopyrightText: 2022 Rane
// SPDX-FileCopyrightText: 2022 Visne
// SPDX-FileCopyrightText: 2022 metalgearsloth
// SPDX-FileCopyrightText: 2022 rolfero
// SPDX-FileCopyrightText: 2023 DrSmugleaf
// SPDX-FileCopyrightText: 2023 Leon Friedrich
// SPDX-FileCopyrightText: 2023 forkeyboards
// SPDX-FileCopyrightText: 2024 Ed
// SPDX-FileCopyrightText: 2025 ScyronX
// SPDX-FileCopyrightText: 2025 ark1368
//
// SPDX-License-Identifier: MPL-2.0

using Content.Shared.Humanoid.Prototypes;
using Content.Shared.Whitelist;
using Robust.Shared.Prototypes;

namespace Content.Shared.Traits;

/// <summary>
/// Describes a trait.
/// </summary>
[Prototype]
public sealed partial class TraitPrototype : IPrototype
{
    [ViewVariables]
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    /// The name of this trait.
    /// </summary>
    [DataField]
    public LocId Name { get; private set; } = string.Empty;

    /// <summary>
    /// The description of this trait.
    /// </summary>
    [DataField]
    public LocId? Description { get; private set; }

    /// <summary>
    /// Don't apply this trait to entities this whitelist IS NOT valid for.
    /// </summary>
    [DataField]
    public EntityWhitelist? Whitelist;

    /// <summary>
    /// Don't apply this trait to entities this whitelist IS valid for. (hence, a blacklist)
    /// </summary>
    [DataField]
    public EntityWhitelist? Blacklist;

    /// <summary>
    /// The components that get added to the player, when they pick this trait.
    /// </summary>
    [DataField]
    public ComponentRegistry Components { get; private set; } = default!;

    /// <summary>
    /// Gear that is given to the player, when they pick this trait.
    /// </summary>
    [DataField]
    public EntProtoId? TraitGear;

    /// <summary>
    /// Trait Price. If negative number, points will be added.
    /// </summary>
    [DataField]
    public int Cost = 0;

    /// <summary>
    /// Adds a trait to a category, allowing you to limit the selection of some traits to the settings of that category.
    /// </summary>
    [DataField]
    public ProtoId<TraitCategoryPrototype>? Category;

        /// <summary>
        ///     List of traits that ca't be taken together with this one.
        /// </summary>
        [DataField]
        public HashSet<ProtoId<TraitPrototype>> MutuallyExclusiveTraits { get; private set; } = new();

        /// <summary>
        ///     List of species that can't have this trait.
        /// </summary>
        [DataField]
        public HashSet<ProtoId<SpeciesPrototype>> SpeciesBlacklist { get; private set; } = new();

    // Einstein Engines - Language begin (remove this if trait system refactor)
    /// <summary>
    ///     The list of all Spoken Languages that this trait adds.
    /// </summary>
    [DataField]
    public List<string>? LanguagesSpoken { get; private set; } = default!;

    /// <summary>
    ///     The list of all Understood Languages that this trait adds.
    /// </summary>
    [DataField]
    public List<string>? LanguagesUnderstood { get; private set; } = default!;

    /// <summary>
    ///     The list of all Spoken Languages that this trait removes.
    /// </summary>
    [DataField]
    public List<string>? RemoveLanguagesSpoken { get; private set; } = default!;

    /// <summary>
    ///     The list of all Understood Languages that this trait removes.
    /// </summary>
    [DataField]
    public List<string>? RemoveLanguagesUnderstood { get; private set; } = default!;
    // Einstein Engines - Language end
}
