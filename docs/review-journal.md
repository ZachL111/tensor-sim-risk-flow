# Review Journal

The repository goal stays the same: create a C# reference implementation for risk workflows, centered on policy evaluation, deny and allow fixtures, and explainable decision traces. This note explains the added review angle.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 191, lane `ship`
- `stress`: `state drift`, score 212, lane `ship`
- `edge`: `review cost`, score 149, lane `ship`
- `recovery`: `decision risk`, score 228, lane `ship`
- `stale`: `input pressure`, score 144, lane `ship`

## Note

The repository should be understandable without pretending it is larger than it is.
