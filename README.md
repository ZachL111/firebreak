# firebreak

`firebreak` is a C# project for Security tooling. It turns model firewall rule precedence and explainable allow-deny decisions into a small local model with readable fixtures and a direct verification command.

## Reading Firebreak

Start with the README, then open `metadata/project.json` to check the constants behind the examples. After that, `fixtures/cases.csv` shows the compact path and `examples/extended_cases.csv` gives a wider look at the same rule.

## Purpose

This project keeps the domain idea close to the tests. That makes it useful as a reference implementation, a small experiment, or a starting point for a more specialized tool.

## Fixture Notes

The examples are meant to be readable before they are exhaustive. They cover enough variation to show how latency and risk can pull a decision below the threshold.

## Design Sketch

The project is organized around a compact model rather than a large framework. Inputs are scored, classified, and checked against golden fixtures. The constants live in code and are mirrored in metadata so documentation drift is easy to catch. The C# code keeps the core model in a small static API and runs checks through the executable path.

## What It Does

- Models trust boundaries with deterministic scoring and explicit review decisions.
- Uses fixture data to keep policy checks changes visible in code review.
- Includes extended examples for replay guards, including `surge` and `degraded`.
- Documents claim validation tradeoffs in `docs/operations.md`.
- Runs locally with a single verification command and no external credentials.

## Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

This runs the language-level build or test path against the compact fixture set.

## Verification

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/audit.ps1
```

The audit command checks repository structure and README constraints before it delegates to the verifier.

## Files Worth Reading

- `src`: primary implementation
- `tests`: verification harness
- `fixtures`: compact golden scenarios
- `examples`: expanded scenario set
- `metadata`: project constants and verification metadata
- `docs`: operations and extension notes
- `scripts`: local verification and audit commands

## Next Directions

- Add a short report command that prints the score breakdown for a single scenario.
- Add malformed input fixtures so the failure path is as visible as the happy path.
- Split the scoring constants into a typed configuration object and validate it before use.
- Add one more security tooling fixture that focuses on a malformed or borderline input.

## Limits

The examples cover useful edges, not every edge. A larger version would add malformed-input tests, richer reports, and deeper domain parsers.

## Setup

Install C# and run the commands from the repository root. The project does not need credentials or a hosted service.
