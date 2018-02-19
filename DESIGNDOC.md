# Design Document

#### Gravity
- We decided to give the player a gravity rotation ability, rotating both gravity and the camera angle.
- Wrote a script to interpolate the angle, using a target angle, shown below:
>angle += (target_angle - angle) * 0.1f;
>Physics2D.gravity = new Vector2((float)Math.Cos((angle - 90) * (Math.PI / 180.0)) * 100, (float)Math.Sin((angle - 90) * (Math.PI / 180.0)) * 100);
- Tried to have the angles stay between (0, 360), but has many problems with interpolation.

#### Aesthetics
- Very minamilistic and blocky.
- The character is a rectangle with eyes.