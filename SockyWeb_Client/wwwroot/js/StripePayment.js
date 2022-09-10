redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51Kx8ecCafy4I0wxOLDU5I9qLePPnHpaZMqSrdX8h1GB3GUYI9fyjC1LIAf1ItjrOnXZ3ociLQFdpF8Tp1uhiNAjt00QRPnlReJ");
    stripe.redirectToCheckout({ sessionId: sessionId });
}