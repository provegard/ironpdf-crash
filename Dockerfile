# Build stage
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

RUN apt-get update && \
    apt-get -y upgrade

WORKDIR /app

COPY ./ .

RUN dotnet build
RUN dotnet publish -c Release -o dist

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:5.0

RUN apt-get update && \
    apt-get -y upgrade && \
    apt-get install -y libc6-dev \
                       libgdiplus

WORKDIR /app
COPY --from=build-env /app/dist .

CMD ./ironpdf-crash
