# TASK: URL Shortener – (eg. Bitly.com) 

The web application should be able to take a url, store it, and give a very small url that links to the original url.

There should be an user interface to add url’s, display the shortened url, and remove urls.

The application should be able to redirect from the shortened url to the original url. 

# Notes

I started with a UserModel, but deleted it. We don't need to worry about User tracking and authentication that way - and it's not part of the specs.

However, URLs need to be deleted, and there should be _some way_ of limiting this.
So we will store an email (or some other user-provided token?) when shrinking a URL.
To delete a given short-URL, the same token must be provided.

That's somewhat naive, but suitable for our current purposes.