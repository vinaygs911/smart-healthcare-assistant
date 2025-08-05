# 🏥 Smart Healthcare Assistant

An open-source, full-stack healthcare diagnostics assistant powered by Agentic AI, Angular 17+, and .NET 8. Designed to demonstrate modern clean architecture, AI-driven design, and real-world healthcare use cases — completely free and publicly available.

---

## 🔧 Tech Stack

### Frontend (Angular 17+)
- Standalone APIs & Signals
- Angular Material UI
- Authenticated routing
- Reactive Forms & RxJS

### Backend (.NET 8)
- Clean Architecture with DDD principles
- MediatR for CQRS pattern
- EF Core 8 with PostgreSQL (prod) & SQLite (dev)
- Serilog for structured logging
- RESTful APIs with Swagger

### Agentic AI
- Modular task-based agents for healthcare diagnostics
- OpenAI integration (mock/fallback supported)
- Future-ready for local LLM or Azure OpenAI deployment

---

## 🧪 Features

- Symptom checker with AI reasoning
- JWT Auth with user roles (Admin, Doctor, Patient)
- Modular components for reusability
- Dockerized setup for dev & prod environments
- Environment-specific configs and DB providers

---

## 🚀 Getting Started

### 🔹 Prerequisites
- Node.js 18+ & Angular CLI
- .NET 8 SDK
- Docker (for full container support)

### 🔹 Local Development

```bash
# Clone the repo
git clone https://github.com/yourusername/smart-healthcare-assistant.git

# Navigate to frontend
cd frontend
npm install
ng serve

# Navigate to backend
cd ../backend
dotnet run
```

---

## 📦 Environment Support

| Environment | Frontend | Backend  | Database     |
|-------------|----------|----------|--------------|
| Development | Angular  | .NET 8   | SQLite       |
| Production  | Angular  | .NET 8   | PostgreSQL   |

---

## 🤖 Agentic AI Capabilities

- Intelligent symptom mapping
- Conversation memory (future)
- Specialist referral suggestions
- Explainable reasoning (mocked for now)

---

## 📂 Folder Structure (Coming Soon)

- `/frontend` - Angular 17+ SPA
- `/backend` - .NET Web API
- `/agents` - AI logic modules
- `/infra` - Docker, CI/CD, DB migrations

---

## 💬 Contributing

We welcome contributions! Please open an issue or PR.  
Check out the `CONTRIBUTING.md` for guidelines.

---

## 📄 License

Apache 2.0 — Free for personal, commercial, and educational use.

---

## 🙌 Credits

Maintained by [Vinay G S](https://www.linkedin.com/in/vinay-gs/)  
Logo/banner by ChatGPT + DALL·E

---

## ⭐️ Give us a star if you like this project and want to support open innovation in healthcare!
