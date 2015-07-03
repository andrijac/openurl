# openurl

**Usage**: <br />
openurl [url]

App is checking if [url] start with one of the following: 

- "http:" 
- "https:" 
- "ftp:"
- "file:" 

If not found, app is appending "http://" by default.

Binary: [https://github.com/andrijac/openurl/tree/master/Bin](https://github.com/andrijac/openurl/tree/master/Bin)

Examples:

- Compose gmail .bat: `openurl "http://mail.google.com/mail/?view=cm&fs=1&tf=1&to=&su=&body="`

- Jira issue finder: `openurl https://[jira account].atlassian.net/browse/%1`
