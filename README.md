# firebreak

`firebreak` is a C# project in security tooling. Its focus is to model firewall rule precedence and explainable allow-deny decisions.

## Use Case

This is intentionally local and self-contained so it can be inspected without credentials, services, or seeded history.

## Firebreak Review Notes

Start with `replay exposure` and `policy width`. Those cases create the widest score spread in this repo, so they are the best quick check when the model changes.

## Highlights

- `fixtures/domain_review.csv` adds cases for trust boundary and claim drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/firebreak-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `replay exposure` and `policy width`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Code Layout

The core code exposes a scoring path and the added review layer uses `signal`, `slack`, `drag`, and `confidence`. The domain terms are `trust boundary`, `claim drift`, `replay exposure`, and `policy width`.

The added C# path is deliberately direct, with fixtures doing most of the explaining.

## Run The Check

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Regression Path

The verifier is intentionally local. It should fail if the fixture score math, lane assignment, or language-specific test drifts.

## Future Work

The fixture set is small enough to audit by hand. The next useful expansion is malformed input coverage, not extra surface area.
