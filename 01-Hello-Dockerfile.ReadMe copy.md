# Working with Docker

> Open terminal at the on the solution folder

## Build

```bash
docker build -f 01-Hello-Dockerfile/Dockerfile \
             -t 01-hello-dockerfile .
```

## Images

```bash
docker image ls | grep "hello"
```

Images ordered by size

```bash
docker images --format "table {{.Size}}\t{{.Repository}}\t{{.Tag}}" | sort -h
```

## Run

create a docker instance

```bash
docker run --rm -it \
    --name helllo-docker-01 \
    -p 8080:8080 \
    -p 8081:8081 \
    01-hello-dockerfile
```

- `--rm`

   - Automatically removes the container when it stops.

- `-it`

   - `-i` (interactive): Keeps the STDIN open, allowing interaction.
   - `-t` (TTY): Allocates a pseudo-TTY, making it work like an interactive terminal.

Run detached

```bash
docker run -d \
    --name helllo-docker-01 \
    -p 8080:8080 \
    -p 8081:8081 \
    01-hello-dockerfile
```

## Test it

```bash
curl http://localhost:8080/demo
```

## Check Running Containers

Show running containers

```bash
docker ps
```

Show all container including stopped

```bash
docker ps -a
```

## Show container logs

```bash
docker logs -f --tail 50 helllo-docker-01
```

- `-f` (follow mode)

   - Continuously streams the logs in real time, similar to tail -f in Linux.
   - New log entries will appear as they are generated.

- `--tail 50`

   - Displays only the last 50 lines of logs initially.

## Stop & Removal

- Stop the Container

```bash
docker stop helllo-docker-01
```

- Remove Container

```bash
docker rm helllo-docker-01
```

- Stop and Remove the Container (force)

```bash
docker rm -f helllo-docker-01
```

- Remove Image

```bash
docker rmi 01-hello-dockerfile
```