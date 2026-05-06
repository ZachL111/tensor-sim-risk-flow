# Tensor Sim Risk Flow Walkthrough

The fixture is intentionally compact, so the review starts with the cases that pull farthest apart.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 191 | ship |
| stress | state drift | 212 | ship |
| edge | review cost | 149 | ship |
| recovery | decision risk | 228 | ship |
| stale | input pressure | 144 | ship |

Start with `recovery` and `stale`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`recovery` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
