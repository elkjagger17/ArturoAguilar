using System;
using Xamarin.Forms;

namespace ExamArturoA.Behavior
{
    /// <summary>
    /// Behavior class
    /// </summary>
	public class EntryBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        /// <summary>
        /// Change for the behavior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            var isValid = default(bool);

            if (!String.IsNullOrEmpty(args.NewTextValue))
                isValid = true;

            ((Entry)sender).BackgroundColor = isValid ? Color.Green : Color.Red;
        }
    }
}
