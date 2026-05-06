# Review Journal

I treated `firebreak` as a project where the smallest useful behavior should still be inspectable.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its security tooling focus without claiming live deployment or external usage.

## Cases

- `baseline`: `trust boundary`, score 136, lane `watch`
- `stress`: `claim drift`, score 162, lane `ship`
- `edge`: `replay exposure`, score 211, lane `ship`
- `recovery`: `policy width`, score 120, lane `watch`
- `stale`: `trust boundary`, score 182, lane `ship`

## Note

This file is intentionally plain so the fixture remains the source of truth.
