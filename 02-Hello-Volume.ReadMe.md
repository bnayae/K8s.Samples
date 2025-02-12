# Working with Docker Volume

> Open terminal at the on the solution folder

## Build

```bash
docker build -f 02-Hello-Volume/Dockerfile \
             -t hellow-docker-volume .
```

## Run

Make sure having the local directory for the mount.

> mounting refers to attaching a storage location
> from the host system to a container.
> This allows data persistence and enables
> sharing files between the host and container

```bash
mkdir -p logs  # Ensure logs folder exists
```

create a docker instance

```bash
docker run --rm -it \
     --name helllo-docker-volume \
     -v $(pwd)/logs:/app/logs \
     -p 8083:8080 \
     -p 8084:8081 \
     hellow-docker-volume
```

- `--rm`

   - Automatically removes the container when it stops.

- `-it`

   - `-i` (interactive): Keeps the STDIN open, allowing interaction.
   - `-t` (TTY): Allocates a pseudo-TTY, making it work like an interactive terminal.

Run detached

```bash
docker run -d \
     --name helllo-docker-volume \
     -v $(pwd)/logs:/app/logs \
     -p 8083:8080 \
     -p 8084:8081 \
     hellow-docker-volume
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
docker logs -f --tail 50 helllo-docker-volume
```

- `-f` (follow mode)

   - Continuously streams the logs in real time, similar to tail -f in Linux.
   - New log entries will appear as they are generated.

- `--tail 50`

   - Displays only the last 50 lines of logs initially.

## Stop & Removal

- Stop the Container

```bash
docker stop helllo-docker-volume
```

- Remove Container

```bash
docker rm helllo-docker-volume
```

- Stop and Remove the Container (force)

```bash
docker rm -f helllo-docker-volume
```

- Remove Image

```bash
docker rmi hellow-docker-volume
```