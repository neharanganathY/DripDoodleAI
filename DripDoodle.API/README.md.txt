# ☕ DripDoodle

**DripDoodle** is a cross-platform application that brings your imagination to life by generating AI-powered doodles directly onto coffee cups. Built with React, ASP.NET Core, and Firebase AI (mocked in development), the app is designed for personalization, creativity, and future AI integration.

## 🚀 Features

- 📸 Capture coffee cup images using your device camera
- ✍️ Type a prompt describing the doodle you want
- 🎨 AI-generated doodles (currently mocked for dev)
- 🖼️ Real-time doodle preview overlaid on the cup
- 💾 Save or print the customized image (coming soon)

## 🛠️ Tech Stack

- **Frontend**: React.js
- **Backend**: ASP.NET Core Web API
- **AI Integration**: Firebase AI (current), OpenAI (archived)
- **Image Handling**: Media Device APIs + Local Image Mock
- **Storage**: Firebase / wwwroot
- **Auth (Planned)**: Firebase Authentication
- **Hosting**: Azure App Services or Firebase Hosting

## 🧪 Mock AI Setup

To simulate AI during MVP:
- A static doodle (`sample-doodle.png`) in `/wwwroot/mock/` is copied dynamically on each API request
- The backend responds with a unique local image URL for frontend preview

This will be replaced by real Firebase AI/ML once the full app is built.

## 📅 Roadmap

- ✅ Backend API with mocked image generation
- ✅ Prompt-based flow end-to-end
- 🔜 Firebase AI integration
- 🔜 Frontend overlay preview
- 🔜 Authentication & image history
- 🔜 Launch as a portfolio project

> ✨ “One commit closer to stars.” — the spirit behind DripDoodle Created by Neha
