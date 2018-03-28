all:
	docker build . -f Dockerfile.base -t mob-ai-csharp
	docker build . -f Dockerfile.builder -t robot-$(BOT_NAME) --network none