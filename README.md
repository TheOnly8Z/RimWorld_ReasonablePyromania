# Reasonable Pyromania
*"We're Pyromanics, but not, like, pyroMANIACs."*

Revamp the Pyromaniac trait to be a double-edged sword, retaining its volatile and risky nature but granting it useful bonuses when managed well.

**This mod is WIP and not yet usable.**

# Trait Changes
## Description
*"NAME loves fire and has a constant need for it in their lives. If their need for fire is sated, they are happier and work harder; otherwise they will start fires randomly, or in extreme cases, self-immolate."*

## Firefighting
*"There's a difference between liking fire and being fine with your house being burned down."*

Pyromaniac trait no longer disables firefighting. However, pawns with this trait default to no firefighting work, as it still carries consequences (see **Fire Need** and **Moodlet**).

## Fire Starting Spree
*"Ehh, I don't feel like setting this antigrain mortar shell on fire today. Maybe I'll stare at that campfire instead."*

No longer randomly enters this mental state.

Pyromaniacs also have unique mental breaks (in addition to fire starting spree) that may happen instead of regular ones when mood is low (see **Mental Break**)

## Opinion
*"We're the duo who will light this rim ablaze!"*

Pyromaniacs gain +20 opinion towards fellow pyromaniacs.

## Lit on Fire
*"The flames and I are one!"*

When on fire, pyromaniacs do not panic unless the fire reaches size 100.

# Fire Piles
*"Look at the flames flicker!"*

A unique building built by pyromaniacs automatically. They cost no resources, give out light and heat like a campfire, but can't be used to cook. If left alone, it will burn out safely in a day or two.

If destroyed through damage, fire piles will cause a small fiery explosion(the pile collapses and the fire spreads nearby).

Deconstructing fire piles has a chance to cause fires (15%), and will also reduce mood of all pyromaniacs (-3 for 3 days, stackable 3x). If done during a pyromaniac's mental break, the pawn will go beserk.

As a recreational action, pyromaniacs may choose to build a fire pile outdoors (like building snowmen). They can also view fire piles and other man-made fires as recreation.

# Fire Need
*"We live by fire and die by fire!"*

Pyromaniacs have a unique needs bar, "Fire". This meter rapidly increases when they see or start fires, and slowly decreases when there isn't any. Additionally, putting out a fire will reduce this meter.

Below certain thresholds, pyromaniac pawns will get increasingly more destructive mental breaks. However, if they are satsified with their fire need, they are actually more productive and happy.

There are five need levels:
- **Desperate** (<1%): Self-immolation (mtb 15 days); -30 mood
- **Demand** (1-20%): Fire starting spree (mtb 30 days); -15 mood
- **Desire** (21%-45%): Fire compulsion (mtb 45 days); -5 mood 
- **Want** (46-75%): Fire watching (mtb 60 days)
- **Satsified**: Global work speed +10%; +5 mood

# Mental Break
*"Fine, I'll make some fire of my own!"*

Pyromaniacs no longer exclusively use Fire starting spree as their mental break. However, it (and the other exclusive mental states) have a much higher weight and will thus be chosen very often for pyromaniacs.

## Mental States

Several new mental states that correspond to break levels. They can trigger as mental break, or randomly if the fire need is not satsified.

### Self-immolation
Only occurs if fire need is below 1%, and never as a mental break.

The pawn will pick a position, and light themselves and the area on fire there. If there are flammable items (like wood), the pawn will pick a position nearby. They will fight anyone who attempts to put out fires near this position.

This is without doubt more dangerous than fire starting spree, as the pawn will always fight back. However, it is entirely preventable with management.

### (Extreme) Fire Starting Spree
Unchanged.

### (Major) Fire Compulsion
The pawn will wander around, building multiple fire piles at random places.

### (Minor) Fire Watching
The pawn will wander around, looking at any fires or any related tiles (like campfires or torches). If none exist, the pawn will build a single fire pile and look at it.

# Moodlets
Pyromaniacs gain various mood bonuses when they see or interact with fire in various ways. If they are Masochists or have Bloodlust, they get an additional bonus in conjunction.

## Pyromaniac-specific

### (+4/+10) Pyromaniac burned by fire
**(With Masochist)** *"This burning sensation... the joy of it is unimaginable!"*

**(Without Masochist)** *"Being burned by fire is a funny feeling. I can get used to it."*

Applies if the pawn has a fire value of >50. Stacks on top of Masochist's pain moodlet, and decays instead of only lasting during the pain.

### (+10/+16) Killed someone with fire
**(With Bloodlust)** *"The thrill... the smell... the sensation of fire and death combined!"*

**(Without Bloodlust)** *"I killed my enemies with fire! I feel powerful!"*

Any pawn that dies when on fire counts. If the pawn has Bloodlust, the mood value is increased, replacing Bloodlust's thought.

### (+6/+12) Witnessed death by fire
**(With Bloodlust)** *"I saw someone die from fire! Their painful screams are like music to my ears!"*

**(Without Bloodlust)** *"I saw someone get claimed by the flames. It was delightful to watch."*

Ditto.

### (+5) Killed insectoid with fire
*"These bugs were made to be roasted... by me! Die! Die! Die!"*

Stackable 3x (0.9x multiplier). Any insectoid that dies when on fire counts.

### (+5) Holding an incendiary weapon
Already exists in and is identical to vanilla, listed here for completionness.

### (-3) Put out a fire
*"I was born to start fires, not stop them. This sucks."*

Stacksable 4x (1.2x multiplier) for each fire the pawn put out. Does not apply when putting themselves out of fire.

### (-8) Pyromaniac in darkness
*"This place needs to be lit up - literally."*

Replaces regular "In Darkness" thought (-5) for Pyromaniacs.

## Non-pyromaniacs
Fire is quite a cruel weapon to use, and most people don't like the idea of using it against other human beings. Using it on animals or insectoids is fair game, though.

Negative thoughts from killing people are nullified by Bloodlust, Pyromaniac or Psychopath.

### (+2) Killed insectoid with fire
*"Burn, you damn bugs!"*

Stackable 3x (0.9x multiplier).

### (-4) Killed someone with fire
*"I killed someone with fire. It was cruel and unnecessary."*

Stackable 3x (0.8x multiplier), applies on top of any other death moods.

### (-2) Witnessed death by fire
*"I saw someone die from fire. The sight of it was uncomfortable."*

Stackable 3x, applies on top of any other death moods.