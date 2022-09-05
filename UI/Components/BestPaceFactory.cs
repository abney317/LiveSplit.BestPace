using LiveSplit.Delta;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;

[assembly: ComponentFactory(typeof(DeltaFactory))]

namespace LiveSplit.Delta
{
    public class DeltaFactory : IComponentFactory
    {
        public string ComponentName => "Best Pace";

        public string Description => "Displays best pace ever based on best split times.";

        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new BestPaceComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "https://beckabney.com/mk64/update.LiveSplit.BestPace.xml";

        public string UpdateURL => "https://beckabney.com/mk64/";

        public Version Version => Version.Parse("2.1.3");
    }
}
