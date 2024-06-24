#!/bin/bash

domains=(yourdomain.com)
rsa_key_size=4096
data_path="./data/certbot"
email="your-email@example.com" # برای دریافت اطلاعیه های تمدید
staging=0 # اگر 1 باشد، از محیط staging (برای تست) استفاده می‌شود

if [ -d "$data_path" ]; then
  read -p "گواهی های موجود یافت شد. آیا می‌خواهید آنها را بازنویسی کنید؟ (y/N) " decision
  if [ "$decision" != "Y" ] && [ "$decision" != "y" ]; then
    exit
  fi
fi

mkdir -p "$data_path/conf"
mkdir -p "$data_path/www"

docker-compose run --rm --entrypoint "\
  certbot certonly --webroot --webroot-path=/var/www/certbot \
  --email $email \
  --agree-tos \
  --no-eff-email \
  --rsa-key-size $rsa_key_size \
  -d ${domains[*]} \
  --force-renewal" certbot
