#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 61917
EXPOSE 44317

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["WishYourDream/WishYourDream.csproj", "WishYourDream/"]
RUN dotnet restore "WishYourDream/WishYourDream.csproj"
COPY . .
WORKDIR "/src/WishYourDream"
RUN dotnet build "WishYourDream.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WishYourDream.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WishYourDream.dll"]