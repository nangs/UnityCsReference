// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;

namespace UnityEngine.Experimental.UIElements
{
    public class Button : BaseTextElement
    {
        public class ButtonFactory : UxmlFactory<Button, ButtonUxmlTraits> {}

        public class ButtonUxmlTraits : BaseTextElementUxmlTraits {}

        public Clickable clickable;

        public Button() : this(null)
        {
        }

        public Button(System.Action clickEvent)
        {
            // Click-once behaviour
            clickable = new Clickable(clickEvent);
            this.AddManipulator(clickable);
        }
    }
}
