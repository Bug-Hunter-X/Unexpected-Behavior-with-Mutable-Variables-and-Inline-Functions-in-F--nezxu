# F# Mutable Variables and Inline Functions Bug

This repository demonstrates an unexpected behavior in F# when using mutable variables with inline functions. The example shows how an inline function appears to capture the initial values of mutable variables, while a regular function uses the updated values.  The solution provides a corrected approach to avoid this issue.

## Bug Description

The provided F# code demonstrates that inline functions in F# can capture the initial values of mutable variables, even after those variables are updated. This can lead to unexpected and incorrect results when working with mutable state.

## Solution

The solution addresses the issue by refactoring the code. Instead of relying on mutable variables, which cause the unexpected side-effect, immutable variables are used with updated values, which makes the logic easier to reason about.  This also ensures that the result is consistent.