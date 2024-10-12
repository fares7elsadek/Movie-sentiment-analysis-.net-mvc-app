# Movie Sentiment Analysis

This is an ASP.NET MVC application that predicts the sentiment (positive or negative) of movie reviews. Users can input a review, and the application will analyze the sentiment using a machine learning model based on Natural Language Processing (NLP) hosted on a Flask API.

## Live Preview

[Movie Sentiment Analysis Live Demo](https://movie-sentiment-analysis.runasp.net/)

## Features

- **Movie Review Sentiment Prediction**: Analyze the sentiment of movie reviews as positive or negative using NLP.
- **Machine Learning Model**: The application leverages an NLP model trained on movie review data for sentiment analysis.
- **Simple and Modern UI**: Responsive design using Bootstrap with a sleek, user-friendly interface.
- **HTTP Client Integration**: The app sends the user's input to a Flask API for sentiment prediction using the pre-trained NLP model.

## How It Works

1. The user submits a movie review in the input box.
2. The review is sent to a Flask API, which uses a pre-trained **machine learning model** and **NLP techniques** to predict the sentiment.
3. The API processes the text using **Natural Language Processing** to transform it into features that the machine learning model can understand.
4. The app displays the result (positive or negative) on the same page.

## NLP and Machine Learning Model

The NLP model used for this project was built and trained on movie review data to classify sentiment as positive or negative. The full NLP model code and training details are available in a separate repository:

[Movie Review Sentiment Analysis NLP Project - Model Repository](https://github.com/fares7elsadek/Movie-review-sentiment-analysis-NLP-Project-)

## Technologies Used

- **ASP.NET Core MVC**: Backend framework used for the app.
- **Flask**: Backend Python framework to serve the machine learning model for sentiment analysis.
- **Python**: Used for building and training the NLP model.
- **Scikit-learn**: Machine learning library used to train the sentiment analysis model.
- **Natural Language Processing (NLP)**: Techniques used to process and analyze text data.
- **Bootstrap**: Frontend framework for responsive design.
- **HTTP Client**: To send and receive data from the Flask API.

## API Integration

The ASP.NET MVC application uses a Flask API for predictions. The API receives a JSON object containing the movie review and responds with the predicted sentiment based on the NLP model.
