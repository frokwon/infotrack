# URL SEO Ranking v1.0

## Introduction

The purpose of this application is to find the rankings of a given URL for given keywords.

It does this by scraping Google using a regular expression, and looping through the matches to find if the URL exists there.

## Possible Improvements

* Saving of rankings to a database to allow the history to be retrieved
* Google could change their markup and/or URL at any time - allow the regular expression and Google URL to be configurable from the database to avoid needing a code release