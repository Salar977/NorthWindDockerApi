FROM nginx:latest

# Remove the default configuration for /etc/nginx/html
# RUN rm /etc/nginx/conf.d/default.conf

COPY restapi.conf /etc/nginx/conf.d

EXPOSE 80
EXPOSE 81

CMD ["nginx", "-g", "daemon off;"]