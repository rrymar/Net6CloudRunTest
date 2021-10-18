## Local machine

> docker build . -t <em>name</em>

> docker run -p 11111:8080 <em>name</em>

## Cloud Run

Option 1

> gcloud run deploy


Option 2
> gcloud builds submit --tag gcr.io/<em>GoogleProjectId/Name</em>

> gcloud run deploy --image gcr.io/<em>GoogleProjectId/Name</em> --platform managed