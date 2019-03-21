﻿using System.Collections.Generic;
using System.Linq;
using OpenTkViewer.Interfaces;
using OpenTkViewer.Models;

namespace OpenTkViewer
{
    public class ViewerScene
    {
        private readonly List<IVisualObject> visualObjects;

        public IEnumerable<IVisualObject> VisualObjects => visualObjects;

        public ViewerScene()
        {
            visualObjects = new List<IVisualObject>();
        }

        public void Add(IVisualObject newVisualObject)
        {
            if(visualObjects.All(x => x != newVisualObject))
                visualObjects.Add(newVisualObject);
        }

        public void Draw()
        {
            foreach (var visualObject in visualObjects)
                visualObject.DrawOnScene();
        }
    }
}
