## Local machine

> docker build . -t <name>

> docker run -p 11111:8080 <name>

## Cloud Run

> gcloud builds submit --tag gcr.io/<GoogleProjectId>/<Name>

> gcloud run deploy --image gcr.io/<GoogleProjectId>/<Name> --platform managed