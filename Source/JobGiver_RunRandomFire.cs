using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using Verse.AI;

namespace ReasonablePyromania
{
	public class JobGiver_RunRandomFire : JobGiver_RunRandom
	{
		protected override Job TryGiveJob(Pawn pawn)
		{
			// Pyromaniacs will not try to panic run unless fire is very big
			Fire fire = (Fire)pawn.GetAttachment(ThingDefOf.Fire);
			if (fire != null && pawn.story.traits.HasTrait(TraitDefOf.Pyromaniac) && fire.fireSize < 100)
			{
				return null;
			}
			// Defer to JobGiver_Wander's implementation
			return base.TryGiveJob(pawn);
		}
	}
}