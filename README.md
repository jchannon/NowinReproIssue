NowinReproIssue
===============

This is a repo to show an issue when an exception is thrown within a Nancy module that the response given by the server is shown as `net::ERR_INCOMPLETE_CHUNKED_ENCODING`

In the code you will see an exception is thrown in `MyClass` and `ErrorStatusCodeHandler` handles the exception and creates a nice error response.  

This has been tested by sending in a `application/json Accept` header.  The Json is returned when using the `KatanaHTTPListenerTest` project but when using the `nowinhost` project the response is either `net::ERR_INCOMPLETE_CHUNKED_ENCODING` or if using Postman you will see `Could not get any response`