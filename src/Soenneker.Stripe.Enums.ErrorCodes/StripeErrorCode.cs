using Soenneker.Gen.EnumValues;

namespace Soenneker.Stripe.Enums.ErrorCodes;

/// <summary>
/// A strongly-typed list of known Stripe error codes returned in API responses, used for handling and categorizing Stripe errors programmatically.
/// </summary>
[EnumValue<string>]
public partial class StripeErrorCode
{
    /// <summary>
    /// The account closed.
    /// </summary>
    public static readonly StripeErrorCode AccountClosed = new("account_closed");
    /// <summary>
    /// The account country invalid address.
    /// </summary>
    public static readonly StripeErrorCode AccountCountryInvalidAddress = new("account_country_invalid_address");
    /// <summary>
    /// The account error country change requires additional steps.
    /// </summary>
    public static readonly StripeErrorCode AccountErrorCountryChangeRequiresAdditionalSteps = new("account_error_country_change_requires_additional_steps");
    /// <summary>
    /// The account information mismatch.
    /// </summary>
    public static readonly StripeErrorCode AccountInformationMismatch = new("account_information_mismatch");
    /// <summary>
    /// The account invalid.
    /// </summary>
    public static readonly StripeErrorCode AccountInvalid = new("account_invalid");
    /// <summary>
    /// The account number invalid.
    /// </summary>
    public static readonly StripeErrorCode AccountNumberInvalid = new("account_number_invalid");
    /// <summary>
    /// The acss debit session incomplete.
    /// </summary>
    public static readonly StripeErrorCode AcssDebitSessionIncomplete = new("acss_debit_session_incomplete");
    /// <summary>
    /// The alipay upgrade required.
    /// </summary>
    public static readonly StripeErrorCode AlipayUpgradeRequired = new("alipay_upgrade_required");
    /// <summary>
    /// The amount too large.
    /// </summary>
    public static readonly StripeErrorCode AmountTooLarge = new("amount_too_large");
    /// <summary>
    /// The amount too small.
    /// </summary>
    public static readonly StripeErrorCode AmountTooSmall = new("amount_too_small");
    /// <summary>
    /// The api key expired.
    /// </summary>
    public static readonly StripeErrorCode ApiKeyExpired = new("api_key_expired");
    /// <summary>
    /// The application fees not allowed.
    /// </summary>
    public static readonly StripeErrorCode ApplicationFeesNotAllowed = new("application_fees_not_allowed");
    /// <summary>
    /// The authentication required.
    /// </summary>
    public static readonly StripeErrorCode AuthenticationRequired = new("authentication_required");
    /// <summary>
    /// The balance insufficient.
    /// </summary>
    public static readonly StripeErrorCode BalanceInsufficient = new("balance_insufficient");
    /// <summary>
    /// The balance invalid parameter.
    /// </summary>
    public static readonly StripeErrorCode BalanceInvalidParameter = new("balance_invalid_parameter");
    /// <summary>
    /// The bank account bad routing numbers.
    /// </summary>
    public static readonly StripeErrorCode BankAccountBadRoutingNumbers = new("bank_account_bad_routing_numbers");
    /// <summary>
    /// The bank account declined.
    /// </summary>
    public static readonly StripeErrorCode BankAccountDeclined = new("bank_account_declined");
    /// <summary>
    /// The bank account exists.
    /// </summary>
    public static readonly StripeErrorCode BankAccountExists = new("bank_account_exists");
    /// <summary>
    /// The bank account restricted.
    /// </summary>
    public static readonly StripeErrorCode BankAccountRestricted = new("bank_account_restricted");
    /// <summary>
    /// The bank account unusable.
    /// </summary>
    public static readonly StripeErrorCode BankAccountUnusable = new("bank_account_unusable");
    /// <summary>
    /// The bank account unverified.
    /// </summary>
    public static readonly StripeErrorCode BankAccountUnverified = new("bank_account_unverified");
    /// <summary>
    /// The bank account verification failed.
    /// </summary>
    public static readonly StripeErrorCode BankAccountVerificationFailed = new("bank_account_verification_failed");
    /// <summary>
    /// The billing invalid mandate.
    /// </summary>
    public static readonly StripeErrorCode BillingInvalidMandate = new("billing_invalid_mandate");
    /// <summary>
    /// The bitcoin upgrade required.
    /// </summary>
    public static readonly StripeErrorCode BitcoinUpgradeRequired = new("bitcoin_upgrade_required");
    /// <summary>
    /// The capture charge authorization expired.
    /// </summary>
    public static readonly StripeErrorCode CaptureChargeAuthorizationExpired = new("capture_charge_authorization_expired");
    /// <summary>
    /// The capture unauthorized payment.
    /// </summary>
    public static readonly StripeErrorCode CaptureUnauthorizedPayment = new("capture_unauthorized_payment");
    /// <summary>
    /// The card decline rate limit exceeded.
    /// </summary>
    public static readonly StripeErrorCode CardDeclineRateLimitExceeded = new("card_decline_rate_limit_exceeded");
    /// <summary>
    /// The card declined.
    /// </summary>
    public static readonly StripeErrorCode CardDeclined = new("card_declined");
    /// <summary>
    /// The cardholder phone number required.
    /// </summary>
    public static readonly StripeErrorCode CardholderPhoneNumberRequired = new("cardholder_phone_number_required");
    /// <summary>
    /// The charge already captured.
    /// </summary>
    public static readonly StripeErrorCode ChargeAlreadyCaptured = new("charge_already_captured");
    /// <summary>
    /// The charge already refunded.
    /// </summary>
    public static readonly StripeErrorCode ChargeAlreadyRefunded = new("charge_already_refunded");
    /// <summary>
    /// The charge disputed.
    /// </summary>
    public static readonly StripeErrorCode ChargeDisputed = new("charge_disputed");
    /// <summary>
    /// The charge exceeds source limit.
    /// </summary>
    public static readonly StripeErrorCode ChargeExceedsSourceLimit = new("charge_exceeds_source_limit");
    /// <summary>
    /// The charge exceeds transaction limit.
    /// </summary>
    public static readonly StripeErrorCode ChargeExceedsTransactionLimit = new("charge_exceeds_transaction_limit");
    /// <summary>
    /// The charge expired for capture.
    /// </summary>
    public static readonly StripeErrorCode ChargeExpiredForCapture = new("charge_expired_for_capture");
    /// <summary>
    /// The charge invalid parameter.
    /// </summary>
    public static readonly StripeErrorCode ChargeInvalidParameter = new("charge_invalid_parameter");
    /// <summary>
    /// The charge not refundable.
    /// </summary>
    public static readonly StripeErrorCode ChargeNotRefundable = new("charge_not_refundable");
    /// <summary>
    /// The clearing code unsupported.
    /// </summary>
    public static readonly StripeErrorCode ClearingCodeUnsupported = new("clearing_code_unsupported");
    /// <summary>
    /// The country code invalid.
    /// </summary>
    public static readonly StripeErrorCode CountryCodeInvalid = new("country_code_invalid");
    /// <summary>
    /// The country unsupported.
    /// </summary>
    public static readonly StripeErrorCode CountryUnsupported = new("country_unsupported");
    /// <summary>
    /// The coupon expired.
    /// </summary>
    public static readonly StripeErrorCode CouponExpired = new("coupon_expired");
    /// <summary>
    /// The customer max payment methods.
    /// </summary>
    public static readonly StripeErrorCode CustomerMaxPaymentMethods = new("customer_max_payment_methods");
    /// <summary>
    /// The customer max subscriptions.
    /// </summary>
    public static readonly StripeErrorCode CustomerMaxSubscriptions = new("customer_max_subscriptions");
    /// <summary>
    /// The customer tax location invalid.
    /// </summary>
    public static readonly StripeErrorCode CustomerTaxLocationInvalid = new("customer_tax_location_invalid");
    /// <summary>
    /// The debit not authorized.
    /// </summary>
    public static readonly StripeErrorCode DebitNotAuthorized = new("debit_not_authorized");
    /// <summary>
    /// The email invalid.
    /// </summary>
    public static readonly StripeErrorCode EmailInvalid = new("email_invalid");
    /// <summary>
    /// The expired card.
    /// </summary>
    public static readonly StripeErrorCode ExpiredCard = new("expired_card");
    /// <summary>
    /// The financial connections account inactive.
    /// </summary>
    public static readonly StripeErrorCode FinancialConnectionsAccountInactive = new("financial_connections_account_inactive");
    /// <summary>
    /// The financial connections no successful transaction refresh.
    /// </summary>
    public static readonly StripeErrorCode FinancialConnectionsNoSuccessfulTransactionRefresh = new("financial_connections_no_successful_transaction_refresh");
    /// <summary>
    /// The forwarding api inactive.
    /// </summary>
    public static readonly StripeErrorCode ForwardingApiInactive = new("forwarding_api_inactive");
    /// <summary>
    /// The forwarding api invalid parameter.
    /// </summary>
    public static readonly StripeErrorCode ForwardingApiInvalidParameter = new("forwarding_api_invalid_parameter");
    /// <summary>
    /// The forwarding api retryable upstream error.
    /// </summary>
    public static readonly StripeErrorCode ForwardingApiRetryableUpstreamError = new("forwarding_api_retryable_upstream_error");
    /// <summary>
    /// The forwarding api upstream connection error.
    /// </summary>
    public static readonly StripeErrorCode ForwardingApiUpstreamConnectionError = new("forwarding_api_upstream_connection_error");
    /// <summary>
    /// The forwarding api upstream connection timeout.
    /// </summary>
    public static readonly StripeErrorCode ForwardingApiUpstreamConnectionTimeout = new("forwarding_api_upstream_connection_timeout");
    /// <summary>
    /// The idempotency key in use.
    /// </summary>
    public static readonly StripeErrorCode IdempotencyKeyInUse = new("idempotency_key_in_use");
    /// <summary>
    /// The incorrect address.
    /// </summary>
    public static readonly StripeErrorCode IncorrectAddress = new("incorrect_address");
    /// <summary>
    /// The incorrect cvc.
    /// </summary>
    public static readonly StripeErrorCode IncorrectCvc = new("incorrect_cvc");
    /// <summary>
    /// The incorrect number.
    /// </summary>
    public static readonly StripeErrorCode IncorrectNumber = new("incorrect_number");
    /// <summary>
    /// The incorrect zip.
    /// </summary>
    public static readonly StripeErrorCode IncorrectZip = new("incorrect_zip");
    /// <summary>
    /// The instant payouts config disabled.
    /// </summary>
    public static readonly StripeErrorCode InstantPayoutsConfigDisabled = new("instant_payouts_config_disabled");
    /// <summary>
    /// The instant payouts currency disabled.
    /// </summary>
    public static readonly StripeErrorCode InstantPayoutsCurrencyDisabled = new("instant_payouts_currency_disabled");
    /// <summary>
    /// The instant payouts limit exceeded.
    /// </summary>
    public static readonly StripeErrorCode InstantPayoutsLimitExceeded = new("instant_payouts_limit_exceeded");
    /// <summary>
    /// The instant payouts unsupported.
    /// </summary>
    public static readonly StripeErrorCode InstantPayoutsUnsupported = new("instant_payouts_unsupported");
    /// <summary>
    /// The insufficient funds.
    /// </summary>
    public static readonly StripeErrorCode InsufficientFunds = new("insufficient_funds");
    /// <summary>
    /// The intent invalid state.
    /// </summary>
    public static readonly StripeErrorCode IntentInvalidState = new("intent_invalid_state");
    /// <summary>
    /// The intent verification method missing.
    /// </summary>
    public static readonly StripeErrorCode IntentVerificationMethodMissing = new("intent_verification_method_missing");
    /// <summary>
    /// The invalid card type.
    /// </summary>
    public static readonly StripeErrorCode InvalidCardType = new("invalid_card_type");
    /// <summary>
    /// The invalid characters.
    /// </summary>
    public static readonly StripeErrorCode InvalidCharacters = new("invalid_characters");
    /// <summary>
    /// The invalid charge amount.
    /// </summary>
    public static readonly StripeErrorCode InvalidChargeAmount = new("invalid_charge_amount");
    /// <summary>
    /// The invalid cvc.
    /// </summary>
    public static readonly StripeErrorCode InvalidCvc = new("invalid_cvc");
    /// <summary>
    /// The invalid expiry month.
    /// </summary>
    public static readonly StripeErrorCode InvalidExpiryMonth = new("invalid_expiry_month");
    /// <summary>
    /// The invalid expiry year.
    /// </summary>
    public static readonly StripeErrorCode InvalidExpiryYear = new("invalid_expiry_year");
    /// <summary>
    /// The invalid mandate reference prefix format.
    /// </summary>
    public static readonly StripeErrorCode InvalidMandateReferencePrefixFormat = new("invalid_mandate_reference_prefix_format");
    /// <summary>
    /// The invalid number.
    /// </summary>
    public static readonly StripeErrorCode InvalidNumber = new("invalid_number");
    /// <summary>
    /// The invalid source usage.
    /// </summary>
    public static readonly StripeErrorCode InvalidSourceUsage = new("invalid_source_usage");
    /// <summary>
    /// The invalid tax location.
    /// </summary>
    public static readonly StripeErrorCode InvalidTaxLocation = new("invalid_tax_location");
    /// <summary>
    /// The invoice no customer line items.
    /// </summary>
    public static readonly StripeErrorCode InvoiceNoCustomerLineItems = new("invoice_no_customer_line_items");
    /// <summary>
    /// The invoice no payment method types.
    /// </summary>
    public static readonly StripeErrorCode InvoiceNoPaymentMethodTypes = new("invoice_no_payment_method_types");
    /// <summary>
    /// The invoice no subscription line items.
    /// </summary>
    public static readonly StripeErrorCode InvoiceNoSubscriptionLineItems = new("invoice_no_subscription_line_items");
    /// <summary>
    /// The invoice not editable.
    /// </summary>
    public static readonly StripeErrorCode InvoiceNotEditable = new("invoice_not_editable");
    /// <summary>
    /// The invoice on behalf of not editable.
    /// </summary>
    public static readonly StripeErrorCode InvoiceOnBehalfOfNotEditable = new("invoice_on_behalf_of_not_editable");
    /// <summary>
    /// The invoice payment intent requires action.
    /// </summary>
    public static readonly StripeErrorCode InvoicePaymentIntentRequiresAction = new("invoice_payment_intent_requires_action");
    /// <summary>
    /// The invoice upcoming none.
    /// </summary>
    public static readonly StripeErrorCode InvoiceUpcomingNone = new("invoice_upcoming_none");
    /// <summary>
    /// The livemode mismatch.
    /// </summary>
    public static readonly StripeErrorCode LivemodeMismatch = new("livemode_mismatch");
    /// <summary>
    /// The lock timeout.
    /// </summary>
    public static readonly StripeErrorCode LockTimeout = new("lock_timeout");
    /// <summary>
    /// The missing.
    /// </summary>
    public static readonly StripeErrorCode Missing = new("missing");
    /// <summary>
    /// The no account.
    /// </summary>
    public static readonly StripeErrorCode NoAccount = new("no_account");
    /// <summary>
    /// The not allowed on standard account.
    /// </summary>
    public static readonly StripeErrorCode NotAllowedOnStandardAccount = new("not_allowed_on_standard_account");
    /// <summary>
    /// The out of inventory.
    /// </summary>
    public static readonly StripeErrorCode OutOfInventory = new("out_of_inventory");
    /// <summary>
    /// The ownership declaration not allowed.
    /// </summary>
    public static readonly StripeErrorCode OwnershipDeclarationNotAllowed = new("ownership_declaration_not_allowed");
    /// <summary>
    /// The parameter invalid empty.
    /// </summary>
    public static readonly StripeErrorCode ParameterInvalidEmpty = new("parameter_invalid_empty");
    /// <summary>
    /// The parameter invalid integer.
    /// </summary>
    public static readonly StripeErrorCode ParameterInvalidInteger = new("parameter_invalid_integer");
    /// <summary>
    /// The parameter invalid string blank.
    /// </summary>
    public static readonly StripeErrorCode ParameterInvalidStringBlank = new("parameter_invalid_string_blank");
    /// <summary>
    /// The parameter invalid string empty.
    /// </summary>
    public static readonly StripeErrorCode ParameterInvalidStringEmpty = new("parameter_invalid_string_empty");
    /// <summary>
    /// The parameter missing.
    /// </summary>
    public static readonly StripeErrorCode ParameterMissing = new("parameter_missing");
    /// <summary>
    /// The parameter unknown.
    /// </summary>
    public static readonly StripeErrorCode ParameterUnknown = new("parameter_unknown");
    /// <summary>
    /// The parameters exclusive.
    /// </summary>
    public static readonly StripeErrorCode ParametersExclusive = new("parameters_exclusive");
    /// <summary>
    /// The payment intent action required.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentActionRequired = new("payment_intent_action_required");
    /// <summary>
    /// The payment intent amount reconfirmation required.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentAmountReconfirmationRequired = new("payment_intent_amount_reconfirmation_required");
    /// <summary>
    /// The payment intent authentication failure.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentAuthenticationFailure = new("payment_intent_authentication_failure");
    /// <summary>
    /// The payment intent automatic tax incomplete.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentAutomaticTaxIncomplete = new("payment_intent_automatic_tax_incomplete");
    /// <summary>
    /// The payment intent incompatible payment method.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentIncompatiblePaymentMethod = new("payment_intent_incompatible_payment_method");
    /// <summary>
    /// The payment intent invalid parameter.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentInvalidParameter = new("payment_intent_invalid_parameter");
    /// <summary>
    /// The payment intent konbini rejected confirmation number.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentKonbiniRejectedConfirmationNumber = new("payment_intent_konbini_rejected_confirmation_number");
    /// <summary>
    /// The payment intent mandate invalid.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentMandateInvalid = new("payment_intent_mandate_invalid");
    /// <summary>
    /// The payment intent payment attempt expired.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentPaymentAttemptExpired = new("payment_intent_payment_attempt_expired");
    /// <summary>
    /// The payment intent payment attempt failed.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentPaymentAttemptFailed = new("payment_intent_payment_attempt_failed");
    /// <summary>
    /// The payment intent unexpected state.
    /// </summary>
    public static readonly StripeErrorCode PaymentIntentUnexpectedState = new("payment_intent_unexpected_state");
    /// <summary>
    /// The payment method bank account already verified.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodBankAccountAlreadyVerified = new("payment_method_bank_account_already_verified");
    /// <summary>
    /// The payment method bank account blocked.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodBankAccountBlocked = new("payment_method_bank_account_blocked");
    /// <summary>
    /// The payment method billing details address missing.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodBillingDetailsAddressMissing = new("payment_method_billing_details_address_missing");
    /// <summary>
    /// The payment method configuration failures.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodConfigurationFailures = new("payment_method_configuration_failures");
    /// <summary>
    /// The payment method currency mismatch.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodCurrencyMismatch = new("payment_method_currency_mismatch");
    /// <summary>
    /// The payment method customer decline.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodCustomerDecline = new("payment_method_customer_decline");
    /// <summary>
    /// The payment method invalid parameter.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodInvalidParameter = new("payment_method_invalid_parameter");
    /// <summary>
    /// The payment method invalid parameter testmode.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodInvalidParameterTestmode = new("payment_method_invalid_parameter_testmode");
    /// <summary>
    /// The payment method microdeposit failed.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodMicrodepositFailed = new("payment_method_microdeposit_failed");

    /// <summary>
    /// The payment method microdeposit verification amounts invalid.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodMicrodepositVerificationAmountsInvalid =
        new("payment_method_microdeposit_verification_amounts_invalid");

    /// <summary>
    /// The payment method microdeposit verification amounts mismatch.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodMicrodepositVerificationAmountsMismatch =
        new("payment_method_microdeposit_verification_amounts_mismatch");

    /// <summary>
    /// The payment method microdeposit verification attempts exceeded.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodMicrodepositVerificationAttemptsExceeded =
        new("payment_method_microdeposit_verification_attempts_exceeded");

    /// <summary>
    /// The payment method microdeposit verification descriptor code mismatch.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodMicrodepositVerificationDescriptorCodeMismatch =
        new("payment_method_microdeposit_verification_descriptor_code_mismatch");

    /// <summary>
    /// The payment method microdeposit verification timeout.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodMicrodepositVerificationTimeout = new("payment_method_microdeposit_verification_timeout");
    /// <summary>
    /// The payment method not available.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodNotAvailable = new("payment_method_not_available");
    /// <summary>
    /// The payment method provider decline.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodProviderDecline = new("payment_method_provider_decline");
    /// <summary>
    /// The payment method provider timeout.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodProviderTimeout = new("payment_method_provider_timeout");
    /// <summary>
    /// The payment method unactivated.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodUnactivated = new("payment_method_unactivated");
    /// <summary>
    /// The payment method unexpected state.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodUnexpectedState = new("payment_method_unexpected_state");
    /// <summary>
    /// The payment method unsupported type.
    /// </summary>
    public static readonly StripeErrorCode PaymentMethodUnsupportedType = new("payment_method_unsupported_type");
    /// <summary>
    /// The payout reconciliation not ready.
    /// </summary>
    public static readonly StripeErrorCode PayoutReconciliationNotReady = new("payout_reconciliation_not_ready");
    /// <summary>
    /// The payouts limit exceeded.
    /// </summary>
    public static readonly StripeErrorCode PayoutsLimitExceeded = new("payouts_limit_exceeded");
    /// <summary>
    /// The payouts not allowed.
    /// </summary>
    public static readonly StripeErrorCode PayoutsNotAllowed = new("payouts_not_allowed");
    /// <summary>
    /// The platform account required.
    /// </summary>
    public static readonly StripeErrorCode PlatformAccountRequired = new("platform_account_required");
    /// <summary>
    /// The platform api key expired.
    /// </summary>
    public static readonly StripeErrorCode PlatformApiKeyExpired = new("platform_api_key_expired");
    /// <summary>
    /// The postal code invalid.
    /// </summary>
    public static readonly StripeErrorCode PostalCodeInvalid = new("postal_code_invalid");
    /// <summary>
    /// The processing error.
    /// </summary>
    public static readonly StripeErrorCode ProcessingError = new("processing_error");
    /// <summary>
    /// The product inactive.
    /// </summary>
    public static readonly StripeErrorCode ProductInactive = new("product_inactive");
    /// <summary>
    /// The progressive onboarding limit exceeded.
    /// </summary>
    public static readonly StripeErrorCode ProgressiveOnboardingLimitExceeded = new("progressive_onboarding_limit_exceeded");
    /// <summary>
    /// The rate limit.
    /// </summary>
    public static readonly StripeErrorCode RateLimit = new("rate_limit");
    /// <summary>
    /// The refer to customer.
    /// </summary>
    public static readonly StripeErrorCode ReferToCustomer = new("refer_to_customer");
    /// <summary>
    /// The refund disputed payment.
    /// </summary>
    public static readonly StripeErrorCode RefundDisputedPayment = new("refund_disputed_payment");
    /// <summary>
    /// The resource already exists.
    /// </summary>
    public static readonly StripeErrorCode ResourceAlreadyExists = new("resource_already_exists");
    /// <summary>
    /// The resource missing.
    /// </summary>
    public static readonly StripeErrorCode ResourceMissing = new("resource_missing");
    /// <summary>
    /// The return intent already processed.
    /// </summary>
    public static readonly StripeErrorCode ReturnIntentAlreadyProcessed = new("return_intent_already_processed");
    /// <summary>
    /// The routing number invalid.
    /// </summary>
    public static readonly StripeErrorCode RoutingNumberInvalid = new("routing_number_invalid");
    /// <summary>
    /// The secret key required.
    /// </summary>
    public static readonly StripeErrorCode SecretKeyRequired = new("secret_key_required");
    /// <summary>
    /// The sepa unsupported account.
    /// </summary>
    public static readonly StripeErrorCode SepaUnsupportedAccount = new("sepa_unsupported_account");
    /// <summary>
    /// The setup attempt failed.
    /// </summary>
    public static readonly StripeErrorCode SetupAttemptFailed = new("setup_attempt_failed");
    /// <summary>
    /// The setup intent authentication failure.
    /// </summary>
    public static readonly StripeErrorCode SetupIntentAuthenticationFailure = new("setup_intent_authentication_failure");
    /// <summary>
    /// The setup intent invalid parameter.
    /// </summary>
    public static readonly StripeErrorCode SetupIntentInvalidParameter = new("setup_intent_invalid_parameter");
    /// <summary>
    /// The setup intent mandate invalid.
    /// </summary>
    public static readonly StripeErrorCode SetupIntentMandateInvalid = new("setup_intent_mandate_invalid");
    /// <summary>
    /// The setup intent mobile wallet unsupported.
    /// </summary>
    public static readonly StripeErrorCode SetupIntentMobileWalletUnsupported = new("setup_intent_mobile_wallet_unsupported");
    /// <summary>
    /// The setup intent setup attempt expired.
    /// </summary>
    public static readonly StripeErrorCode SetupIntentSetupAttemptExpired = new("setup_intent_setup_attempt_expired");
    /// <summary>
    /// The setup intent unexpected state.
    /// </summary>
    public static readonly StripeErrorCode SetupIntentUnexpectedState = new("setup_intent_unexpected_state");
    /// <summary>
    /// The shipping address invalid.
    /// </summary>
    public static readonly StripeErrorCode ShippingAddressInvalid = new("shipping_address_invalid");
    /// <summary>
    /// The shipping calculation failed.
    /// </summary>
    public static readonly StripeErrorCode ShippingCalculationFailed = new("shipping_calculation_failed");
    /// <summary>
    /// The sku inactive.
    /// </summary>
    public static readonly StripeErrorCode SkuInactive = new("sku_inactive");
    /// <summary>
    /// The state unsupported.
    /// </summary>
    public static readonly StripeErrorCode StateUnsupported = new("state_unsupported");
    /// <summary>
    /// The status transition invalid.
    /// </summary>
    public static readonly StripeErrorCode StatusTransitionInvalid = new("status_transition_invalid");
    /// <summary>
    /// The stripe tax inactive.
    /// </summary>
    public static readonly StripeErrorCode StripeTaxInactive = new("stripe_tax_inactive");
    /// <summary>
    /// The tax id invalid.
    /// </summary>
    public static readonly StripeErrorCode TaxIdInvalid = new("tax_id_invalid");
    /// <summary>
    /// The tax id prohibited.
    /// </summary>
    public static readonly StripeErrorCode TaxIdProhibited = new("tax_id_prohibited");
    /// <summary>
    /// The taxes calculation failed.
    /// </summary>
    public static readonly StripeErrorCode TaxesCalculationFailed = new("taxes_calculation_failed");
    /// <summary>
    /// The terminal location country unsupported.
    /// </summary>
    public static readonly StripeErrorCode TerminalLocationCountryUnsupported = new("terminal_location_country_unsupported");
    /// <summary>
    /// The terminal reader busy.
    /// </summary>
    public static readonly StripeErrorCode TerminalReaderBusy = new("terminal_reader_busy");
    /// <summary>
    /// The terminal reader hardware fault.
    /// </summary>
    public static readonly StripeErrorCode TerminalReaderHardwareFault = new("terminal_reader_hardware_fault");
    /// <summary>
    /// The terminal reader invalid location for activation.
    /// </summary>
    public static readonly StripeErrorCode TerminalReaderInvalidLocationForActivation = new("terminal_reader_invalid_location_for_activation");
    /// <summary>
    /// The terminal reader invalid location for payment.
    /// </summary>
    public static readonly StripeErrorCode TerminalReaderInvalidLocationForPayment = new("terminal_reader_invalid_location_for_payment");
    /// <summary>
    /// The terminal reader offline.
    /// </summary>
    public static readonly StripeErrorCode TerminalReaderOffline = new("terminal_reader_offline");
    /// <summary>
    /// The terminal reader timeout.
    /// </summary>
    public static readonly StripeErrorCode TerminalReaderTimeout = new("terminal_reader_timeout");
    /// <summary>
    /// The testmode charges only.
    /// </summary>
    public static readonly StripeErrorCode TestmodeChargesOnly = new("testmode_charges_only");
    /// <summary>
    /// The tls version unsupported.
    /// </summary>
    public static readonly StripeErrorCode TlsVersionUnsupported = new("tls_version_unsupported");
    /// <summary>
    /// The token already used.
    /// </summary>
    public static readonly StripeErrorCode TokenAlreadyUsed = new("token_already_used");
    /// <summary>
    /// The token card network invalid.
    /// </summary>
    public static readonly StripeErrorCode TokenCardNetworkInvalid = new("token_card_network_invalid");
    /// <summary>
    /// The token in use.
    /// </summary>
    public static readonly StripeErrorCode TokenInUse = new("token_in_use");
    /// <summary>
    /// The transfer source balance parameters mismatch.
    /// </summary>
    public static readonly StripeErrorCode TransferSourceBalanceParametersMismatch = new("transfer_source_balance_parameters_mismatch");
    /// <summary>
    /// The transfers not allowed.
    /// </summary>
    public static readonly StripeErrorCode TransfersNotAllowed = new("transfers_not_allowed");
    /// <summary>
    /// The url invalid.
    /// </summary>
    public static readonly StripeErrorCode UrlInvalid = new("url_invalid");
}