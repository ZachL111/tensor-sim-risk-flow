# tensor-sim-risk-flow

`tensor-sim-risk-flow` is a C# project in simulations. Its focus is to create a C# reference implementation for risk workflows, centered on policy evaluation, deny and allow fixtures, and explainable decision traces.

## Why It Exists

The point is to make a small domain rule concrete enough that a reader can change it and immediately see what broke.

## Tensor Sim Risk Flow Review Notes

Start with `decision risk` and `input pressure`. Those cases create the widest score spread in this repo, so they are the best quick check when the model changes.

## Features

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/tensor-sim-risk-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `decision risk` and `input pressure`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Architecture Notes

The fixture data drives the tests. The code stays thin, while `metadata/domain-review.json` and `config/review-profile.json` explain what each case is meant to protect.

The C# addition stays small enough to inspect in one sitting.

## Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Tests

The same command runs the local verification path. The highest-scoring domain case is `recovery` at 228, which lands in `ship`. The most cautious case is `stale` at 144, which lands in `ship`.

## Limitations And Roadmap

The repository is intentionally scoped to local checks. I would expand it by adding adversarial fixtures before adding features.
