mkcert "microservicesolution.dev" "*.microservicesolution.dev" 
kubectl create namespace microservicesolution
kubectl create secret tls -n microservicesolution microservicesolution-tls --cert=./microservicesolution.dev+1.pem  --key=./microservicesolution.dev+1-key.pem