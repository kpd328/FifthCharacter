﻿using System.Windows.Input;

namespace FifthCharacter.Plugin.Interface {
    public interface IFeature {
        string Name { get; }
        string ID { get; }
        string Source { get; }
        string Text { get; }
        /// <summary>
        /// IsActive determines whether or not the feature has a limited number of uses which reset given a condition
        /// such as a short or long rest
        /// </summary>
        bool IsActive { get; }
        /// <summary>
        /// ActiveUses should only be initialized to something other than zero iff IsActive is set to true
        /// </summary>
        int ActiveUses { get; }
        /// <summary>
        /// IsAbilityMod determines whethe or not the feature modifies an ability score upon taking the feature.
        /// </summary>
        bool IsAbilityMod { get; }

        /// <summary>
        /// This must be implemented with a lambda containing the line:
        /// <c>PopupNavigation.Instance.PushAsync(new PopupFeature(this));</c>
        /// so that the OnTapGestureRecognizer on the FeaturesList View
        /// can work properly for Android, iOS, and UWP.
        /// </summary>
        ICommand Popup { get; }

        IFeature GetInstance();
        /// <summary>
        /// ModAbility is called when a feature is taken and has <c>IsAbilityMod</c> set to <c>true</c>.
        /// If <c>IsAbilityMod</c> is <c>false</c> then ModAbility should throw an error if called.
        /// </summary>
        void ModAbility();
    }
}
