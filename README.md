[![](https://img.shields.io/nuget/v/soenneker.stripe.enums.errorcodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.errorcodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.errorcodes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.errorcodes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.enums.errorcodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.errorcodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.errorcodes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.errorcodes/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Enums.ErrorCodes

Provides strongly typed values for Stripe API error codes so applications can branch on known failures without duplicating protocol strings.

## Installation

```bash
dotnet add package Soenneker.Stripe.Enums.ErrorCodes
```

## Usage

```csharp
using Soenneker.Stripe.Enums.ErrorCodes;

if (StripeErrorCode.TryFromValue(stripeError.Code, out StripeErrorCode? code))
{
    if (code == StripeErrorCode.ApiKeyExpired)
    {
        // Alert the operator and stop retrying with this credential.
    }
}
```

Use `TryFromValue` when Stripe may introduce a code newer than this package, and `FromValue` when unknown values should fail immediately. Error codes describe machine-actionable causes; use Stripe's message or your own safe customer copy rather than exposing internal details.
