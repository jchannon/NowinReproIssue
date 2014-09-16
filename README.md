NowinReproIssue
===============

This is a repo to show an issue when an exception is thrown within a Nancy module that the response given by the server is shown as `net::ERR_INCOMPLETE_CHUNKED_ENCODING`

In the code you will see an exception is thrown in `MyClass` and `ErrorStatusCodeHandler` handles the exception and creates a nice error response.  

This has been tested by sending in a `application/json Accept` header.  The Json is returned when using the `KatanaHTTPListenerTest` project but when using the `nowinhost` project the response is either `net::ERR_INCOMPLETE_CHUNKED_ENCODING` or if using Postman you will see `Could not get any response`

###Nancy 

You will need to clone Nancy and alter your `sln` file so it picks it up properly. I cloned and then did `git checkout 152641de2f01fd83f463b92ff8cca4df9d0d384b` which is the commit of latest release.