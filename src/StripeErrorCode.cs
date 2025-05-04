using Intellenum;

namespace Soenneker.Stripe.Enums.ErrorCodes;

/// <summary>
/// A strongly-typed list of known Stripe error codes returned in API responses, used for handling and categorizing Stripe errors programmatically.
/// </summary>
[Intellenum<string>]
public partial class StripeErrorCode
{
    /// <summary>Generic error code returned when no other error code applies</summary>
    public static readonly StripeErrorCode InvalidRequestError = new("invalid_request_error");

    /// <summary>The card has been declined for an unknown reason</summary>
    public static readonly StripeErrorCode CardDeclined = new("card_declined");

    /// <summary>The card has insufficient funds to complete the purchase</summary>
    public static readonly StripeErrorCode InsufficientFunds = new("insufficient_funds");

    /// <summary>The card is expired</summary>
    public static readonly StripeErrorCode ExpiredCard = new("expired_card");

    /// <summary>The CVC number is incorrect</summary>
    public static readonly StripeErrorCode IncorrectCvc = new("incorrect_cvc");

    /// <summary>The card number is incorrect</summary>
    public static readonly StripeErrorCode IncorrectNumber = new("incorrect_number");

    /// <summary>The card’s expiration month is incorrect</summary>
    public static readonly StripeErrorCode IncorrectExpMonth = new("incorrect_exp_month");

    /// <summary>The card’s expiration year is incorrect</summary>
    public static readonly StripeErrorCode IncorrectExpYear = new("incorrect_exp_year");

    /// <summary>The card was declined for suspected fraud</summary>
    public static readonly StripeErrorCode Fraudulent = new("fraudulent");

    /// <summary>The customer has exceeded the balance or credit limit</summary>
    public static readonly StripeErrorCode AmountTooLarge = new("amount_too_large");

    /// <summary>The provided bank account has been declined</summary>
    public static readonly StripeErrorCode BankAccountDeclined = new("bank_account_declined");

    /// <summary>The charge has already been captured</summary>
    public static readonly StripeErrorCode ChargeAlreadyCaptured = new("charge_already_captured");

    /// <summary>The charge has already been refunded</summary>
    public static readonly StripeErrorCode ChargeAlreadyRefunded = new("charge_already_refunded");

    /// <summary>The charge has been disputed by the cardholder</summary>
    public static readonly StripeErrorCode DisputedCharge = new("disputed_charge");

    /// <summary>The payment method is not supported</summary>
    public static readonly StripeErrorCode PaymentMethodUnsupported = new("payment_method_unsupported");

    /// <summary>The card was declined by the issuing bank</summary>
    public static readonly StripeErrorCode ProcessingError = new("processing_error");

    /// <summary>The authentication attempt failed</summary>
    public static readonly StripeErrorCode AuthenticationError = new("authentication_error");

    /// <summary>The charge was declined due to a generic error</summary>
    public static readonly StripeErrorCode GenericDecline = new("generic_decline");

    /// <summary>The issuer declined the request to create a token</summary>
    public static readonly StripeErrorCode TokenAlreadyUsed = new("token_already_used");

    /// <summary>The request requires an idempotency key</summary>
    public static readonly StripeErrorCode IdempotencyKeyInUse = new("idempotency_key_in_use");

    /// <summary>The request was rate-limited</summary>
    public static readonly StripeErrorCode RateLimit = new("rate_limit");

    /// <summary>The setup attempt failed for an unknown reason</summary>
    public static readonly StripeErrorCode SetupAttemptFailed = new("setup_attempt_failed");

    /// <summary>Customer has no attached payment method</summary>
    public static readonly StripeErrorCode NoPaymentMethod = new("no_payment_method");

    /// <summary>The request used an incorrect API key</summary>
    public static readonly StripeErrorCode InvalidApiKey = new("invalid_api_key");

    /// <summary>The client secret was incorrect or expired</summary>
    public static readonly StripeErrorCode InvalidClientSecret = new("invalid_client_secret");

    /// <summary>The payment intent status does not allow this operation</summary>
    public static readonly StripeErrorCode InvalidPaymentIntentStatus = new("invalid_payment_intent_status");

    /// <summary>The mandate is invalid or not usable</summary>
    public static readonly StripeErrorCode InvalidMandate = new("invalid_mandate");

    /// <summary>The customer’s account was closed</summary>
    public static readonly StripeErrorCode AccountClosed = new("account_closed");

    /// <summary>The customer's account was disabled or rejected</summary>
    public static readonly StripeErrorCode AccountDisabled = new("account_disabled");

    /// <summary>The source is already used or attached</summary>
    public static readonly StripeErrorCode SourceUsed = new("source_used");

    /// <summary>The provided source has been lost or revoked</summary>
    public static readonly StripeErrorCode SourceRevoked = new("source_revoked");

    /// <summary>The bank account has failed verification</summary>
    public static readonly StripeErrorCode VerificationFailed = new("verification_failed");

    /// <summary>The account cannot currently accept charges</summary>
    public static readonly StripeErrorCode AccountNotEnabled = new("account_not_enabled");

    /// <summary>The provided coupon code is invalid or expired</summary>
    public static readonly StripeErrorCode InvalidCoupon = new("invalid_coupon");

    /// <summary>The subscription cannot be updated or canceled</summary>
    public static readonly StripeErrorCode SubscriptionNotUpdatable = new("subscription_not_updatable");
}