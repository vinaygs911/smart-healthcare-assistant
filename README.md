# 🏥 Smart Healthcare Assistant

An open-source, full-stack healthcare diagnostics assistant powered by **Agentic AI, Angular 17+, and .NET 8**.  
Designed to demonstrate **clean architecture, AI-driven workflows, and real-world healthcare use cases** — completely free and publicly available.

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

## 📐 Architecture Overview

This project adopts the **Next Full-Stack Shift**:  
**.NET + Angular + AI (LLM → MCP → Agents)**

```
 ┌─────────────────────────────┐
 │        Angular UI            │
 │  - Chat / Copilot panel      │
 │  - Forms (encounter, order)  │
 │  - Streaming token viewer    │
 │  - Tool traces + citations   │
 └─────────────▲────────────────┘
               │ SSE / REST
               │
 ┌─────────────┴────────────────┐
 │      .NET AI Gateway API     │
 │  - ChatController (SSE)      │
 │  - Provider adapters (OpenAI)│
 │  - Safety filters, RBAC      │
 └─────────────▲────────────────┘
               │ delegates
               │
 ┌─────────────┴────────────────┐
 │     Agent Orchestrator       │
 │  - Supervisor Agent          │
 │  - TriageAgent (symptoms)    │
 │  - CodingAgent (ICD-10/CPT)  │
 │  - ImagingAgent (PACS)       │
 │  - DataAgent (policies/RAG)  │
 └─────────────▲────────────────┘
               │ tool calls
               │
   ┌───────────┴───────────┐
   │       MCP Tool Servers │
   │────────────────────────│
   │ FHIR/EHR  ─ read/write │
   │ PACS/DICOM ─ imaging   │
   │ RAG KB    ─ SOP/policy │
   │ Observability ─ ops    │
   │ Scheduling/Payments    │
   └───────────▲───────────┘
               │ HTTP/gRPC
               │
 ┌─────────────┴────────────────┐
 │   Core .NET Backend           │
 │  - Domain • Application       │
 │  - Infrastructure (clients)   │
 │  - Adapters (FHIR, PACS, etc) │
 └─────────────▲────────────────┘
               │
   ┌───────────┴───────────┐
   │      Data Stores       │
   │────────────────────────│
   │ Relational DB (EHR ops)│
   │ Vector DB (pgvector)   │
   │ Blob storage (docs)    │
   └────────────────────────┘
```

📄 For a clean PDF version with business cases, see  
[Smart Healthcare Assistant — Architecture & Business Cases (PDF)](./docs/smart-healthcare-assistant-architecture.pdf)

---

## 💡 Business Cases

- 🩺 **Intelligent Triage** — symptom input → AI reasoning + policy lookup → safe clinical suggestions  
- 💳 **Coding Copilot** — FHIR read → ICD-10 / CPT draft suggestions → billing support  
- 🖼 **Imaging Assistant** — PACS queries + dose policy checks → study recommendations  
- 📑 **Policy & SOP Q&A** — RAG-backed answers with citations → compliance made easy  
- ⚙ **Ops Copilot** — observability insights → faster MTTR for on-call developers  

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
git clone https://github.com/vinaygs911/smart-healthcare-assistant.git

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
- `/docs` - Architecture diagrams & PDF

---

## 💬 Contributing

We welcome contributions! Please open an issue or PR.  
Check out the `CONTRIBUTING.md` for guidelines.

---

## 📄 License

Apache 2.0 — Free for personal, commercial, and educational use.

---

## 🙌 Credits

Maintained by [Vinay G S](https://www.linkedin.com/in/gsvinaymakam)  
Logo/banner by ChatGPT + DALL·E

---

## ⭐️ Support

Give us a ⭐️ if you like this project and want to support open innovation in healthcare!
