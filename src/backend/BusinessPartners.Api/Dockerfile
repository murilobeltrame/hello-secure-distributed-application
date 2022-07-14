FROM openjdk:17 as builder
WORKDIR /src

COPY . .
RUN ./mvnw package -DskipTests

FROM openjdk:17
EXPOSE 8080
WORKDIR /app

COPY --from=builder src/target/business-partners-api-0.0.1-SNAPSHOT.jar ./app.jar
ENTRYPOINT ["java","-jar","/app.jar"]