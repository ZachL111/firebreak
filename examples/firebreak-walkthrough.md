# Firebreak Walkthrough

This note is the quickest way to read the extra review model in `firebreak`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | trust boundary | 136 | watch |
| stress | claim drift | 162 | ship |
| edge | replay exposure | 211 | ship |
| recovery | policy width | 120 | watch |
| stale | trust boundary | 182 | ship |

Start with `edge` and `recovery`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

If `recovery` becomes less cautious without a clear reason, I would inspect the drag input first.
