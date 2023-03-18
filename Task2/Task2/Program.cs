using Task2;

class Program
{
    static void Main(string[] args)
    {
        GenerateBranches();
    }

    static void GenerateBranches()
    {
        Branch root = new Branch();

        Branch branch1 = new Branch();
        Branch branch2 = new Branch();

        root.AddBranch(branch1);
        root.AddBranch(branch2);

        Branch branch3 = new Branch();
        Branch branch4 = new Branch();
        Branch branch5 = new Branch();
        Branch branch6 = new Branch();

        branch1.AddBranch(branch3);
        branch2.AddBranch(branch4);
        branch2.AddBranch(branch5);
        branch2.AddBranch(branch6);

        Branch branch7 = new Branch();
        Branch branch8 = new Branch();
        Branch branch9 = new Branch();

        branch4.AddBranch(branch7);
        branch5.AddBranch(branch8);
        branch5.AddBranch(branch9);

        Branch branch10 = new Branch();

        branch8.AddBranch(branch10);

        List<Branch> allBranches = GetAllBranches(root);

        foreach (Branch branch in allBranches)
        {
            int depth = GetDepth(root, branch);
            Console.WriteLine($"Branch at depth {depth}: {branch}");
        }
    }

    static List<Branch> GetAllBranches(Branch branch)
    {
        List<Branch> allBranches = new List<Branch>();
        allBranches.Add(branch);

        foreach (Branch childBranch in branch.GetBranches())
        {
            List<Branch> childBranches = GetAllBranches(childBranch);
            allBranches.AddRange(childBranches);
        }

        return allBranches;
    }


    static int GetDepth(Branch root, Branch branch)
    {
        if (root == branch)
        {
            return 1;
        }

        foreach (Branch childBranch in root.GetBranches())
        {
            int depth = GetDepth(childBranch, branch);

            if (depth != -1)
            {
                return depth + 1;
            }
        }

        return -1;
    }
}

