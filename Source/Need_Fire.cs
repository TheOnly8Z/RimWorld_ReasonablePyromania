using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace ReasonablePyromania
{
	public class Need_Fire : Need
	{
		public override int GUIChangeArrow => -1;

		private const float ThreshSatisfied = 0.75f;
		private const float ThreshWant = 0.45f;
		private const float ThreshDesire = 0.2f;
		private const float ThreshDemand = 0.01f;

		public FireDesireCategory CurCategory
		{
			get
			{
				if (CurLevel > ThreshSatisfied)
				{
					return FireDesireCategory.Satisfied;
				}
				if (CurLevel > ThreshWant)
				{
					return FireDesireCategory.Want;
				}
				if (CurLevel > ThreshDesire)
				{
					return FireDesireCategory.Desire;
				}
				if (CurLevel > ThreshDemand)
				{
					return FireDesireCategory.Demand;
				}
				return FireDesireCategory.Desperate;
			}
		}

		public override float CurLevel
		{
			get
			{
				return base.CurLevel;
			}
			set
			{
				FireDesireCategory curCategory = CurCategory;
				base.CurLevel = value;
			}
		}

		private float FireNeedFallPerTick => def.fallPerDay / 60000f;

		public Need_Fire(Pawn pawn)
			: base(pawn)
		{
			threshPercents = new List<float>();
			threshPercents.Add(ThreshSatisfied);
			threshPercents.Add(ThreshWant);
			threshPercents.Add(ThreshDesire);
			threshPercents.Add(ThreshDemand);
		}

		public override void SetInitialLevel()
		{
			base.CurLevelPercentage = Rand.Range(0.6f, 1f);
		}

		public override void NeedInterval()
		{
			if (!IsFrozen)
			{
				CurLevel -= FireNeedFallPerTick * 150f;
			}
		}
	}

}
