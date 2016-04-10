using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace ShuzenEngine
{
    abstract class Entity
    {
        protected ContentManager EntityContent { get; set; } //all content used by the entity like graphics and sound
        protected bool IsSuggestible { get; set; } //is suggestible by physics
        protected bool IsBlockíng { get; set; }
        protected EntityType entityType { get; set; }

        public virtual void LoadContent(ContentManager content)
        {
            EntityContent = new ContentManager(content.ServiceProvider, content.RootDirectory);
        }
        public virtual void Update(GameTime gt)
        {

        }
        public virtual void Draw(SpriteBatch sb)
        {

        }
    }

    public enum EntityType
    {
        Object,
        Neutral,
        Enemy,
        Ally        
    }
}
