# GeneratorTeste

**Overview:**
GeneratorTeste is a C# application designed to manage and generate tests. It features multiple forms for different functionalities such as user registration, test management, and result display. The project requires a large database that is not included in the repository and must be obtained by contacting the project owner.

**Key Functionalities:**

1. **Form Management:**
   - **FormaInregistrare:** Manages user registration with necessary input fields and validations.
   - **FormaLogare:** Handles user login ensuring secure access to the application.
   - **FormaMeniu:** The main menu form providing navigation to different parts of the application.
   - **FormaProfil:** Displays and allows editing of user profiles.
   - **FormaRealizari:** Shows user achievements within the application.
   - **FormaRezultat:** Displays detailed results of the tests taken by users.
   - **FormaRezultatTest:** Specific form for displaying test results, including scores and feedback.
   - **FormaTest:** Manages the test-taking process, presenting questions and recording answers.

2. **Database Interaction:**
   - Utilizes Entity Framework for seamless database operations.
   - Models such as `t_Intrebari` and `t_Conturi` are used for structured data management.

3. **UI Components:**
   - Incorporates Windows Forms controls like `TabControl`, `Label`, `Button`, and `PictureBox`.
   - Uses custom components like `LollipopButton` and `LollipopTextBox` for improved UI/UX.

4. **Administrative Tools:**
   - Provides tools for administrators to create, edit, and manage tests and questions.
   - Features for viewing and analyzing test results are included.

**Setup Instructions:**
To run the application, download the source code from the [GitHub Repository](https://github.com/clk11/GeneratorTeste) and contact the project owner at trasca.robert2003@gmail.com to obtain the database.

**Languages:**
- C#
