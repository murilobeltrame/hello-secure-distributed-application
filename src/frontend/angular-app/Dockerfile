FROM node:17-alpine as builder

WORKDIR /src
COPY . .
RUN npm ci
RUN npm run build

FROM nginx:1.23-alpine

COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=builder /src/dist/angular-app /usr/share/nginx/html