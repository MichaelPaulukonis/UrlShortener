# TASK: URL Shortener – (eg. Bitly.com) 

The web application should be able to take a url, store it, and give a very small url that links to the original url.

There should be an user interface to add url’s, display the shortened url, and remove urls.

The application should be able to redirect from the shortened url to the original url. 

# Notes

If a URL already exists in the repository, it shouldn't be/can't be added twice.
"Shouldn't" because duplication
"Can't" because implementation means keys will be identical
So, if somebody wants to delete a shorturl, maybe they should provide an authentication token
While this is part of the models, there's not prompting on the Delete page, so we're not using this now.

Code is sadly crude.

Unit-Testing started out well, but I realized I was getting bogged down in testing models that didn't reflect actual usage.

And once I started implementing usage, I didn't go back and add more tests.
Which fail, becuase I'm using a Session var.

The repository started simple in-memory with plans to use a file-based or localDB-based version, but never got to that phase of implementation.

Project was started as Web API with the intention of having separate API and web-app projects, but ended up being all bollixed together.

Page layouts use the default Bootstrap template. Lists use the default Web API Help Pages layout and CSS.
CSS should have been pruned and renamed, since classes refer to api elements.
vendor JS has not been pruned, either.
Bundling and minification has not been implemented.
Naming is not consistent.
There is no logging.
Error handling is default behavior, for the most-part.