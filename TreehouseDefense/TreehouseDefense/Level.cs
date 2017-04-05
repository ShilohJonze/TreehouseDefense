using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreehouseDefense
{
    class Level
    {
        private Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            // Run until all invaders are neautralized or an invader reaches the end of path.
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders):
                }

                //Count and move the invaders that are still being active.
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    { 
                        invader.Move();

                    if (invader.HasScored)
                        {
                        return false;
                    }

                    remainingInvaders++;
                } 
            }
        }
            return true;
    }
}